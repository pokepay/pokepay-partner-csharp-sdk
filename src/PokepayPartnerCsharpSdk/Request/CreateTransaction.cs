// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateTransaction
    {
        public string ShopId { get; set; }
        public string CustomerId { get; set; }
        public string PrivateMoneyId { get; set; }
        #nullable enable
        public int? MoneyAmount { get; set; }
        #nullable enable
        public int? PointAmount { get; set; }
        #nullable enable
        public string? PointExpiresAt { get; set; }
        #nullable enable
        public string? Description { get; set; }

        public CreateTransaction(string shopId, string customerId, string privateMoneyId) =>
            (ShopId, CustomerId, PrivateMoneyId) = (shopId, customerId, privateMoneyId);

        private string path { get { return "/transactions"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

        #nullable enable
        public async Task<TransactionDetail?> Send(Client client) {
            string res = await client.Send(path, CreateTransaction.method, this);
            return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
    }
}
