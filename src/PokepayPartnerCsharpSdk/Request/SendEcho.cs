// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class SendEcho
    {
#if NETFRAMEWORK
        public string Message { get; set; }
#else
        public string Message { get; set; }
#endif

        public SendEcho(string message) =>
            (Message) = (message);

        private string path { get { return "/echo"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

#if NETFRAMEWORK
        public async Task<Echo> Send(Client client) {
                string res = await client.Send(path, SendEcho.method, this);
                return JsonSerializer.Deserialize<Echo>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<Echo?> Send(Client client) {
                string res = await client.Send(path, SendEcho.method, this);
                return JsonSerializer.Deserialize<Echo>(res, client.JsonOptions);
        }
#endif
    }
}
