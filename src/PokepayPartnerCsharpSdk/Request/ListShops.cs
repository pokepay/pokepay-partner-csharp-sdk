// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class ListShops
    {
#if NETFRAMEWORK
        public string OrganizationCode { get; set; }
        public string PrivateMoneyId { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string ExternalId { get; set; }
        public bool WithDisabled { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
#else
        #nullable enable
        public string? OrganizationCode { get; set; }
        #nullable enable
        public string? PrivateMoneyId { get; set; }
        #nullable enable
        public string? Name { get; set; }
        #nullable enable
        public string? PostalCode { get; set; }
        #nullable enable
        public string? Address { get; set; }
        #nullable enable
        public string? Tel { get; set; }
        #nullable enable
        public string? Email { get; set; }
        #nullable enable
        public string? ExternalId { get; set; }
        #nullable enable
        public bool? WithDisabled { get; set; }
        #nullable enable
        public int? Page { get; set; }
        #nullable enable
        public int? PerPage { get; set; }
#endif
        private string path { get { return "/shops"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<PaginatedShops> Send(Client client) {
                string res = await client.Send(path, ListShops.method, this);
                return JsonSerializer.Deserialize<PaginatedShops>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<PaginatedShops?> Send(Client client) {
                string res = await client.Send(path, ListShops.method, this);
                return JsonSerializer.Deserialize<PaginatedShops>(res, client.JsonOptions);
        }
#endif
    }
}
