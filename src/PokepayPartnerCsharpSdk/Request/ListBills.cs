// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class ListBills
    {
#if NETFRAMEWORK
        public System.Nullable<int> Page { get; set; }
        public System.Nullable<int> PerPage { get; set; }
        public string BillId { get; set; }
        public string PrivateMoneyId { get; set; }
        public string OrganizationCode { get; set; }
        public string Description { get; set; }
        public string CreatedFrom { get; set; }
        public string CreatedTo { get; set; }
        public string ShopName { get; set; }
        public string ShopId { get; set; }
        public System.Nullable<int> LowerLimitAmount { get; set; }
        public System.Nullable<int> UpperLimitAmount { get; set; }
        public System.Nullable<bool> IsDisabled { get; set; }
#else
        #nullable enable
        public int? Page { get; set; }
        #nullable enable
        public int? PerPage { get; set; }
        #nullable enable
        public string? BillId { get; set; }
        #nullable enable
        public string? PrivateMoneyId { get; set; }
        #nullable enable
        public string? OrganizationCode { get; set; }
        #nullable enable
        public string? Description { get; set; }
        #nullable enable
        public string? CreatedFrom { get; set; }
        #nullable enable
        public string? CreatedTo { get; set; }
        #nullable enable
        public string? ShopName { get; set; }
        #nullable enable
        public string? ShopId { get; set; }
        #nullable enable
        public int? LowerLimitAmount { get; set; }
        #nullable enable
        public int? UpperLimitAmount { get; set; }
        #nullable enable
        public bool? IsDisabled { get; set; }
#endif
        private string path { get { return "/bills"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<PaginatedBills> Send(Client client) {
                string res = await client.Send(path, ListBills.method, this);
                return JsonSerializer.Deserialize<PaginatedBills>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<PaginatedBills?> Send(Client client) {
                string res = await client.Send(path, ListBills.method, this);
                return JsonSerializer.Deserialize<PaginatedBills>(res, client.JsonOptions);
        }
#endif
    }
}
