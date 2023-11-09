// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateTopupTransactionWithCheck
    {
#if NETFRAMEWORK
        public string CheckId { get; set; }
        public string CustomerId { get; set; }
        public string RequestId { get; set; }
#else
        public string CheckId { get; set; }
        public string CustomerId { get; set; }
        #nullable enable
        public string? RequestId { get; set; }
#endif

        public CreateTopupTransactionWithCheck(string checkId, string customerId) =>
            (CheckId, CustomerId) = (checkId, customerId);

        private string path { get { return "/transactions" + "/topup" + "/check"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

#if NETFRAMEWORK
        public async Task<TransactionDetail> Send(Client client) {
                string res = await client.Send(path, CreateTopupTransactionWithCheck.method, this);
                return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<TransactionDetail?> Send(Client client) {
                string res = await client.Send(path, CreateTopupTransactionWithCheck.method, this);
                return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
#endif
    }
}
