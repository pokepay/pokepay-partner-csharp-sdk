// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class GetAccount
    {
        private string AccountId { get; set; }
#if NETFRAMEWORK
#else
#endif

        public GetAccount(string accountId) =>
            (AccountId) = (accountId);

        private string path { get { return "/accounts" + "/" + AccountId; } }

        private static readonly HttpMethod method = new HttpMethod("GET");

#if NETFRAMEWORK
        public async Task<AccountDetail> Send(Client client) {
                string res = await client.Send(path, GetAccount.method, this);
                return JsonSerializer.Deserialize<AccountDetail>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<AccountDetail?> Send(Client client) {
                string res = await client.Send(path, GetAccount.method, this);
                return JsonSerializer.Deserialize<AccountDetail>(res, client.JsonOptions);
        }
#endif
    }
}
