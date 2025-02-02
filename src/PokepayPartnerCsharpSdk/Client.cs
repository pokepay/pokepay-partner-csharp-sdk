using System;
using System.IO;
using System.Web;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Authentication;

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
        public string RequestMethod { get; }
        public string Data { get; }
        public string PartnerClientId { get; }

        [JsonConstructor]
        public SendBodyData(string requestMethod, string data, string partnerClientId) =>
            (RequestMethod, Data, PartnerClientId) = (requestMethod, data, partnerClientId);
    }

    public class ReceiveBodyData
    {
        public string ResponseData { get; set; }
        public string Timestamp { get; set; }
        public string PartnerClientId { get; set; }

        [JsonConstructor]
        public ReceiveBodyData(string timestamp, string partnerClientId) =>
            (Timestamp, PartnerClientId) = (timestamp, partnerClientId);
    }

    public class ErrorResponse
    {
        public string Type { get; set; }
        public string Message { get; set; }
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
        private readonly int MaxRetries;

        public readonly HttpClient HttpClient;
        public readonly JsonSerializerOptions JsonOptions;

        private static HttpClient GetHttpClient(string certPem, string rsaKeyPem) {
#if NETFRAMEWORK
            byte[] pfx = (new X509Certificate2Collection(X509FromPemFile.CreateFromPemFile(certPem, rsaKeyPem))).Export(X509ContentType.Pfx);
#else
            // see https://www.daimto.com/how-to-use-x509certificate2-with-pem-file/
            byte[] pfx = X509Certificate2.CreateFromPemFile(certPem, rsaKeyPem).Export(X509ContentType.Pfx);
#endif
            X509Certificate2 cert = new X509Certificate2(pfx);
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificates.Clear();
            handler.ClientCertificates.Add(cert);
            handler.SslProtocols = SslProtocols.Tls12;
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            return new HttpClient(handler);
        }

        public Client(string configFilePath) {
            if (configFilePath.StartsWith("~")) {
                string home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                configFilePath = configFilePath.Replace("~", home);
            }
            Config = new IniFile(configFilePath);
            ClientId = Config.GetValue("", "CLIENT_ID");
            try
            {
                ClientSecret = Encrypter.DecodeBase64Url(Config.GetValue("", "CLIENT_SECRET"));
            }
            catch (FormatException)
            {
                throw new FormatException("invalid CLIENT_SECRET format");
            }
            BaseUrl = Config.GetValue("", "API_BASE_URL");
            var timeout = Config.GetValue("", "TIMEOUT", "10");
            var cert = Config.GetValue("", "SSL_CERT_FILE");
            var key = Config.GetValue("", "SSL_KEY_FILE");
            var maxRetries = Config.GetValue("", "MAX_RETRIES", "2");
            if (Int32.TryParse(maxRetries, out int numMaxRetries)) {
              MaxRetries = numMaxRetries;
            }

            try
            {
                HttpClient = Client.GetHttpClient(cert, key);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Invalid client certification configuration", e);
            }
            if (Int32.TryParse(timeout, out int numTimeout)) {
              if (numTimeout != 0) {
                HttpClient.Timeout = TimeSpan.FromSeconds(numTimeout);
              }
            }
            Rng = new RNGCryptoServiceProvider();
            JsonOptions = new JsonSerializerOptions {
                PropertyNamingPolicy = new SnakeCaseNamingPolicy(),
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        }

        public async Task<string> Send(string path, HttpMethod method, object data)
        {
            var retryCount = 0;
            var isRetriableMethod = method.ToString().Equals("GET");
            var hasRequestId = data.GetType().GetMethod("RequestId") != null;
            var isRetriable = isRetriableMethod || hasRequestId;
            HttpResponseMessage response;
            while (true) {
              try {
                RequestBodyData requestBodyData = new RequestBodyData(
                    data,
                    DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                    Guid.NewGuid().ToString());

                string requestBodyString = JsonSerializer.Serialize(requestBodyData, JsonOptions);

                // Console.WriteLine("*** ReqBody: {0}", requestBodyString);

                string requestBodyEnc = Encrypter.EncryptData(requestBodyString, ClientSecret);

                SendBodyData sendBodyData = new SendBodyData(
                    method.ToString(),
                    requestBodyEnc,
                    ClientId);

                string sendBodyString = JsonSerializer.Serialize(sendBodyData, JsonOptions);

                HttpRequestMessage request = new HttpRequestMessage {
                  Method = path.Equals("/ping") ? HttpMethod.Get : HttpMethod.Post, // pingの場合はサーバー側でbodyのrequest_methodを無視するのでGETを指定する必要がある
                         RequestUri = new Uri(BaseUrl + path),
                         Content = path.Equals("/ping") ? null : new StringContent(sendBodyString, System.Text.Encoding.UTF8, "application/json"),
                };

                response = await HttpClient.SendAsync(request);
                if ((int)response.StatusCode == 503) {
                  if (isRetriable && retryCount < MaxRetries) {
                    ++retryCount;
                    Thread.Sleep(3000);
                    continue;
                  }
                }
              }
              catch (OperationCanceledException ex) when (ex.InnerException is TimeoutException tex)
              {
                  if (isRetriable && retryCount < MaxRetries) {
                    ++retryCount;
                    continue;
                  }
                throw;
              }
              break;
            }
            string responseString = await response.Content.ReadAsStringAsync();

            // Console.WriteLine("*** Status: {0}", response.StatusCode);
            // Console.WriteLine("*** RawResp: {0}", responseString);

            ReceiveBodyData receiveBodyData = JsonSerializer.Deserialize<ReceiveBodyData>(responseString, JsonOptions);

            if (receiveBodyData.ResponseData == null) {
                // "response_data" was not found in response? it maybe Ping?
                if (200 <= (int) response.StatusCode && (int) response.StatusCode < 300) {
                    return responseString;
                }
                throw new HttpRequestException(responseString, null);
            }

            string responseDataString = Encrypter.DecryptData(receiveBodyData.ResponseData, ClientSecret);

            // Console.WriteLine("*** Body: {0}", responseDataString);

            if (200 <= (int) response.StatusCode && (int) response.StatusCode < 300) {
                return responseDataString;
            }

            ErrorResponse errorResponse = JsonSerializer.Deserialize<ErrorResponse>(responseDataString, JsonOptions);

            if (errorResponse.Type == null || errorResponse.Message == null) {
                return responseDataString;
            }

            HttpRequestException err = new HttpRequestException(
                errorResponse.Type + ": " + errorResponse.Message,
                null);

            err.Data.Add("StatusCode", (int) response.StatusCode);
            err.Data.Add("Body", responseDataString);
            err.Data.Add("Type", errorResponse.Type);
            err.Data.Add("Message", errorResponse.Message);

            throw err;
        }
    }
}
