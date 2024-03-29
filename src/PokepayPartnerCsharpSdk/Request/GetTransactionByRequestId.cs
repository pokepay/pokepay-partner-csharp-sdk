// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetTransactionByRequestId
    {
        private string RequestId { get; set; }
#if NETFRAMEWORK
#else
#endif

        public GetTransactionByRequestId(string requestId) =>
            (RequestId) = (requestId);

        private string path { get { return "/transactions" + "/requests" + "/" + RequestId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<TransactionDetail> Send(Client client) {
                string res = await client.Send(path, GetTransactionByRequestId.method, this);
                return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<TransactionDetail?> Send(Client client) {
                string res = await client.Send(path, GetTransactionByRequestId.method, this);
                return JsonSerializer.Deserialize<TransactionDetail>(res, client.JsonOptions);
        }
#endif
    }
}
