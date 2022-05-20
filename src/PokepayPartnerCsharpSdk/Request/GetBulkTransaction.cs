// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetBulkTransaction
    {
        private string BulkTransactionId { get; set; }

        public GetBulkTransaction(string bulkTransactionId) =>
            (BulkTransactionId) = (bulkTransactionId);

        private string path { get { return "/bulk-transactions" + "/" + BulkTransactionId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

        public async Task<BulkTransaction> Send(Client client) {
            string res = await client.Send(path, GetBulkTransaction.method, this);
            return JsonSerializer.Deserialize<BulkTransaction>(res, client.JsonOptions);
        }
    }
}
