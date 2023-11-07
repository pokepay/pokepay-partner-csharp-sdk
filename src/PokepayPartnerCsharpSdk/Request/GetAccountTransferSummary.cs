// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetAccountTransferSummary
    {
        private string AccountId { get; set; }
        #nullable enable
        public string? From { get; set; }
        #nullable enable
        public string? To { get; set; }
        #nullable enable
        public string[]? TransferTypes { get; set; }

        public GetAccountTransferSummary(string accountId) =>
            (AccountId) = (accountId);

        private string path { get { return "/accounts" + "/" + AccountId + "/transfers" + "/summary"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

        #nullable enable
        public async Task<AccountTransferSummary?> Send(Client client) {
            string res = await client.Send(path, GetAccountTransferSummary.method, this);
            return JsonSerializer.Deserialize<AccountTransferSummary>(res, client.JsonOptions);
        }
    }
}
