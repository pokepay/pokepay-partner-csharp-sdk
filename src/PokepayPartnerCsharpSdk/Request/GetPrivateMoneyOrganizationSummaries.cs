// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetPrivateMoneyOrganizationSummaries
    {
        private string PrivateMoneyId { get; set; }
#if NETFRAMEWORK
        public string From { get; set; }
        public string To { get; set; }
        public System.Nullable<int> Page { get; set; }
        public System.Nullable<int> PerPage { get; set; }
#else
        #nullable enable
        public string? From { get; set; }
        #nullable enable
        public string? To { get; set; }
        #nullable enable
        public int? Page { get; set; }
        #nullable enable
        public int? PerPage { get; set; }
#endif

        public GetPrivateMoneyOrganizationSummaries(string privateMoneyId) =>
            (PrivateMoneyId) = (privateMoneyId);

        private string path { get { return "/private-moneys" + "/" + PrivateMoneyId + "/organization-summaries"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<PaginatedPrivateMoneyOrganizationSummaries> Send(Client client) {
                string res = await client.Send(path, GetPrivateMoneyOrganizationSummaries.method, this);
                return JsonSerializer.Deserialize<PaginatedPrivateMoneyOrganizationSummaries>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<PaginatedPrivateMoneyOrganizationSummaries?> Send(Client client) {
                string res = await client.Send(path, GetPrivateMoneyOrganizationSummaries.method, this);
                return JsonSerializer.Deserialize<PaginatedPrivateMoneyOrganizationSummaries>(res, client.JsonOptions);
        }
#endif
    }
}
