// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class ListCoupons
    {
#if NETFRAMEWORK
        public string PrivateMoneyId { get; set; }
        public string CouponId { get; set; }
        public string CouponName { get; set; }
        public string IssuedShopName { get; set; }
        public string AvailableShopName { get; set; }
        public string AvailableFrom { get; set; }
        public string AvailableTo { get; set; }
        public System.Nullable<int> Page { get; set; }
        public System.Nullable<int> PerPage { get; set; }
#else
        public string PrivateMoneyId { get; set; }
        #nullable enable
        public string? CouponId { get; set; }
        #nullable enable
        public string? CouponName { get; set; }
        #nullable enable
        public string? IssuedShopName { get; set; }
        #nullable enable
        public string? AvailableShopName { get; set; }
        #nullable enable
        public string? AvailableFrom { get; set; }
        #nullable enable
        public string? AvailableTo { get; set; }
        #nullable enable
        public int? Page { get; set; }
        #nullable enable
        public int? PerPage { get; set; }
#endif

        public ListCoupons(string privateMoneyId) =>
            (PrivateMoneyId) = (privateMoneyId);

        private string path { get { return "/coupons"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<PaginatedCoupons> Send(Client client) {
                string res = await client.Send(path, ListCoupons.method, this);
                return JsonSerializer.Deserialize<PaginatedCoupons>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<PaginatedCoupons?> Send(Client client) {
                string res = await client.Send(path, ListCoupons.method, this);
                return JsonSerializer.Deserialize<PaginatedCoupons>(res, client.JsonOptions);
        }
#endif
    }
}
