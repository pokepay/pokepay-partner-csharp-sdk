#nullable enable
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

        public SendEcho(string message) => (Message) = (message);

        static readonly string _path = "/echo";
        static readonly HttpMethod _method = HttpMethod.Post;

        public async Task<Echo> Send(Client client) {
            string res = await client.Send(SendEcho._path, SendEcho._method, this);
            return JsonSerializer.Deserialize<Echo>(res, client.JsonOptions)!;
        }
    }
}
