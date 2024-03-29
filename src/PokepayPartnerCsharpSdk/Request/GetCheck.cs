// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetCheck
    {
        private string CheckId { get; set; }
#if NETFRAMEWORK
#else
#endif

        public GetCheck(string checkId) =>
            (CheckId) = (checkId);

        private string path { get { return "/checks" + "/" + CheckId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<Check> Send(Client client) {
                string res = await client.Send(path, GetCheck.method, this);
                return JsonSerializer.Deserialize<Check>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<Check?> Send(Client client) {
                string res = await client.Send(path, GetCheck.method, this);
                return JsonSerializer.Deserialize<Check>(res, client.JsonOptions);
        }
#endif
    }
}
