// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class ListAccountBalances
    {
        private string AccountId { get; set; }
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public string? ExpiresAtFrom { get; set; }
        public string? ExpiresAtTo { get; set; }
        public string? Direction { get; set; }

        public ListAccountBalances(string accountId) =>
            (AccountId) = (accountId);

        private string path { get { return "/accounts" + "/" + AccountId + "/balances"; } }

        private static readonly HttpMethod method = HttpMethod.Get;

        public async Task<PaginatedAccountBalance> Send(Client client) {
            string res = await client.Send(path, ListAccountBalances.method, this);
            return JsonSerializer.Deserialize<PaginatedAccountBalance>(res, client.JsonOptions)!;
        }
    }
}
