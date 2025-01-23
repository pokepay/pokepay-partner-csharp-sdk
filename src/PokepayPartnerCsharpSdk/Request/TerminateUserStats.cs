// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class TerminateUserStats
    {
#if NETFRAMEWORK
        public string OperationId { get; set; }
#else
        public string OperationId { get; set; }
#endif

        public TerminateUserStats(string operationId) =>
            (OperationId) = (operationId);

        private string path { get { return "/user-stats" + "/terminate"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

#if NETFRAMEWORK
        public async Task<UserStatsOperation> Send(Client client) {
                string res = await client.Send(path, TerminateUserStats.method, this);
                return JsonSerializer.Deserialize<UserStatsOperation>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<UserStatsOperation?> Send(Client client) {
                string res = await client.Send(path, TerminateUserStats.method, this);
                return JsonSerializer.Deserialize<UserStatsOperation>(res, client.JsonOptions);
        }
#endif
    }
}
