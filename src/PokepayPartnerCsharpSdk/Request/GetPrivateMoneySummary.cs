// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetPrivateMoneySummary
    {
        private string PrivateMoneyId { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public GetPrivateMoneySummary(string privateMoneyId) =>
            (PrivateMoneyId) = (privateMoneyId);

        private string path { get { return "/private-moneys" + "/" + PrivateMoneyId + "/summary"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

        public async Task<PrivateMoneySummary> Send(Client client) {
            string res = await client.Send(path, GetPrivateMoneySummary.method, this);
            return JsonSerializer.Deserialize<PrivateMoneySummary>(res, client.JsonOptions);
        }
    }
}
