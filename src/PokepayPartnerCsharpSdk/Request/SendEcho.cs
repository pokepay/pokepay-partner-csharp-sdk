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
        public string Message { get; set; }

        public SendEcho(string message) =>
            (Message) = (message);

        private string path { get { return "/echo"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

        #nullable enable
        public async Task<Echo?> Send(Client client) {
            string res = await client.Send(path, SendEcho.method, this);
            return JsonSerializer.Deserialize<Echo>(res, client.JsonOptions);
        }
    }
}
