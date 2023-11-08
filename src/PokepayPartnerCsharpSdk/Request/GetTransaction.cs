// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetTransaction
    {
        private string TransactionId { get; set; }

        public GetTransaction(string transactionId) =>
            (TransactionId) = (transactionId);

        private string path { get { return "/transactions" + "/" + TransactionId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

        #nullable enable
        public async Task<TransactionDetail?> Send(Client client) {
            string res = await client.Send(path, GetTransaction.method, this);
            return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
    }
}
