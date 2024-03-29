// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class BulkCreateTransaction
    {
#if NETFRAMEWORK
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string RequestId { get; set; }
        public string PrivateMoneyId { get; set; }
#else
        public string Name { get; set; }
        #nullable enable
        public string? Description { get; set; }
        public string Content { get; set; }
        public string RequestId { get; set; }
        #nullable enable
        public string? PrivateMoneyId { get; set; }
#endif

        public BulkCreateTransaction(string name, string content, string requestId) =>
            (Name, Content, RequestId) = (name, content, requestId);

        private string path { get { return "/transactions" + "/bulk"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

#if NETFRAMEWORK
        public async Task<BulkTransaction> Send(Client client) {
                string res = await client.Send(path, BulkCreateTransaction.method, this);
                return JsonSerializer.Deserialize<BulkTransaction>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<BulkTransaction?> Send(Client client) {
                string res = await client.Send(path, BulkCreateTransaction.method, this);
                return JsonSerializer.Deserialize<BulkTransaction>(res, client.JsonOptions);
        }
#endif
    }
}
