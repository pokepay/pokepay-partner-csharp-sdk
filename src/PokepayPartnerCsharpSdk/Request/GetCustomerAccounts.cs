// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetCustomerAccounts
    {
        public string PrivateMoneyId { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
        public string CreatedAtFrom { get; set; }
        public string CreatedAtTo { get; set; }
        public bool IsSuspended { get; set; }
        public string Status { get; set; }
        public string ExternalId { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public GetCustomerAccounts(string privateMoneyId) =>
            (PrivateMoneyId) = (privateMoneyId);

        private string path { get { return "/accounts" + "/customers"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

        public async Task<PaginatedAccountWithUsers> Send(Client client) {
            string res = await client.Send(path, GetCustomerAccounts.method, this);
            return JsonSerializer.Deserialize<PaginatedAccountWithUsers>(res, client.JsonOptions);
        }
    }
}
