// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class ListTransfers
    {
#if NETFRAMEWORK
        public string From { get; set; }
        public string To { get; set; }
        public System.Nullable<int> Page { get; set; }
        public System.Nullable<int> PerPage { get; set; }
        public string ShopId { get; set; }
        public string ShopName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string TransactionId { get; set; }
        public string PrivateMoneyId { get; set; }
        public System.Nullable<bool> IsModified { get; set; }
        public string[] TransactionTypes { get; set; }
        public string[] TransferTypes { get; set; }
        public string Description { get; set; }
#else
        #nullable enable
        public string? From { get; set; }
        #nullable enable
        public string? To { get; set; }
        #nullable enable
        public int? Page { get; set; }
        #nullable enable
        public int? PerPage { get; set; }
        #nullable enable
        public string? ShopId { get; set; }
        #nullable enable
        public string? ShopName { get; set; }
        #nullable enable
        public string? CustomerId { get; set; }
        #nullable enable
        public string? CustomerName { get; set; }
        #nullable enable
        public string? TransactionId { get; set; }
        #nullable enable
        public string? PrivateMoneyId { get; set; }
        #nullable enable
        public bool? IsModified { get; set; }
        #nullable enable
        public string[]? TransactionTypes { get; set; }
        #nullable enable
        public string[]? TransferTypes { get; set; }
        #nullable enable
        public string? Description { get; set; }
#endif
        private string path { get { return "/transfers"; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<PaginatedTransfers> Send(Client client) {
                string res = await client.Send(path, ListTransfers.method, this);
                return JsonSerializer.Deserialize<PaginatedTransfers>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<PaginatedTransfers?> Send(Client client) {
                string res = await client.Send(path, ListTransfers.method, this);
                return JsonSerializer.Deserialize<PaginatedTransfers>(res, client.JsonOptions);
        }
#endif
    }
}
