// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetExternalTransactionByRequestId
    {
        private string RequestId { get; set; }
#if NETFRAMEWORK
#else
#endif

        public GetExternalTransactionByRequestId(string requestId) =>
            (RequestId) = (requestId);

        private string path { get { return "/external-transactions" + "/requests" + "/" + RequestId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<ExternalTransactionDetail> Send(Client client) {
                string res = await client.Send(path, GetExternalTransactionByRequestId.method, this);
                return JsonSerializer.Deserialize<ExternalTransactionDetail>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<ExternalTransactionDetail?> Send(Client client) {
                string res = await client.Send(path, GetExternalTransactionByRequestId.method, this);
                return JsonSerializer.Deserialize<ExternalTransactionDetail>(res, client.JsonOptions);
        }
#endif
    }
}
