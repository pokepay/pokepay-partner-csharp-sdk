// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class DeleteAccount
    {
        private string AccountId { get; set; }
#if NETFRAMEWORK
        public System.Nullable<bool> Cashback { get; set; }
#else
        #nullable enable
        public bool? Cashback { get; set; }
#endif

        public DeleteAccount(string accountId) =>
            (AccountId) = (accountId);

        private string path { get { return "/accounts" + "/" + AccountId; } }

        private static readonly HttpMethod method = new HttpMethod("DELETE");

#if NETFRAMEWORK
        public async Task<AccountDeleted> Send(Client client) {
                string res = await client.Send(path, DeleteAccount.method, this);
                return JsonSerializer.Deserialize<AccountDeleted>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<AccountDeleted?> Send(Client client) {
                string res = await client.Send(path, DeleteAccount.method, this);
                return JsonSerializer.Deserialize<AccountDeleted>(res, client.JsonOptions);
        }
#endif
    }
}
