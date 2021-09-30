#nullable enable
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Authentication;
using System;
using System.IO;
using System.Web;
using System.Linq;

namespace PokepayPartnerCsharpSdk
{
    public class RequestBodyData
    {
        public object RequestData { get; }
        public string Timestamp { get; }
        public string PartnerCallId { get; }

        [JsonConstructor]
        public RequestBodyData(object requestData, string timestamp, string partnerCallId) =>
            (RequestData, Timestamp, PartnerCallId) = (requestData, timestamp, partnerCallId);
    }

    public class SendBodyData
    {
        public string Data { get; }
        public string PartnerClientId { get; }

        [JsonConstructor]
        public SendBodyData(string data, string partnerClientId) =>
            (Data, PartnerClientId) = (data, partnerClientId);
    }

    public class ReceiveBodyData
    {
        public string? ResponseData { get; set; }
        public string Timestamp { get; set; }
        public string PartnerClientId { get; set; }

        [JsonConstructor]
        public ReceiveBodyData(string timestamp, string partnerClientId) =>
            (Timestamp, PartnerClientId) = (timestamp, partnerClientId);
    }

    public static class ExtensionMethods {
        public static string ToSnakeCase(this string str)
        {
            return string.Concat(
                str.Select(
                    (x, i) =>
                    (i > 0 && char.IsUpper(x)) ?
                    "_" + x :
                    x.ToString())
                ).ToLower();
        }
    }

    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToSnakeCase();
        }
    }

    public class Client
    {
        private readonly IniFile Config;
        private readonly string ClientId;
        private readonly Byte[] ClientSecret;
        private readonly string BaseUrl;
        private readonly RNGCryptoServiceProvider Rng;

        public readonly HttpClient HttpClient;
        public readonly JsonSerializerOptions JsonOptions;

        private static HttpClient GetHttpClient(string certPem, string rsaKeyPem) {
            X509Certificate2 cert = X509Certificate2.CreateFromPemFile(certPem, rsaKeyPem);
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificates.Clear();
            handler.ClientCertificates.Add(cert);
            handler.SslProtocols = SslProtocols.Tls12;
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            return new HttpClient(handler);
        }

        public Client(string configFilePath) {
            Config = new IniFile(configFilePath);
            ClientId = Config.GetValue("", "CLIENT_ID");
            ClientSecret = Encrypter.DecodeBase64Url(Config.GetValue("", "CLIENT_SECRET"));
            BaseUrl = Config.GetValue("", "API_BASE_URL");
            HttpClient = Client.GetHttpClient(
                Config.GetValue("", "SSL_CERT_FILE"),
                Config.GetValue("", "SSL_KEY_FILE")
                );
            Rng = new RNGCryptoServiceProvider();
            JsonOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = new SnakeCaseNamingPolicy()
            };
        }

        public async Task<string> Send(string path, HttpMethod method, object data)
        {
            RequestBodyData requestBodyData = new RequestBodyData(
                data,
                DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                Guid.NewGuid().ToString());

            string requestBodyString = JsonSerializer.Serialize(requestBodyData, JsonOptions);
            string requestBodyEnc = Encrypter.EncryptData(requestBodyString, ClientSecret);

            SendBodyData sendBodyData = new SendBodyData(
                requestBodyEnc,
                ClientId);

            string sendBodyString = JsonSerializer.Serialize(sendBodyData, JsonOptions);

            HttpRequestMessage request = new HttpRequestMessage {
                Method = method,
                RequestUri = new Uri(BaseUrl + path),
                Content = new StringContent(sendBodyString, System.Text.Encoding.UTF8, "application/json"),
            };

            var response = await HttpClient.SendAsync(request);
            string responseString = await response.Content.ReadAsStringAsync();

            ReceiveBodyData receiveBodyData = JsonSerializer.Deserialize<ReceiveBodyData>(responseString, JsonOptions)!;

            if (receiveBodyData.ResponseData == null) {
                // "response_data" was not found in response? it maybe Ping?
                // FIXME: deserialize
                Console.WriteLine("{0}", responseString);
                return "";
            }

            string responseDataString = Encrypter.DecryptData(receiveBodyData.ResponseData, ClientSecret);

            return responseDataString;
        }
    }
}
