// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateBank
    {
        private string UserDeviceId { get; set; }
#if NETFRAMEWORK
        public string PrivateMoneyId { get; set; }
        public string CallbackUrl { get; set; }
        public string Kana { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }
#else
        public string PrivateMoneyId { get; set; }
        public string CallbackUrl { get; set; }
        public string Kana { get; set; }
        #nullable enable
        public string? Email { get; set; }
        #nullable enable
        public string? Birthdate { get; set; }
#endif

        public CreateBank(string userDeviceId, string privateMoneyId, string callbackUrl, string kana) =>
            (UserDeviceId, PrivateMoneyId, CallbackUrl, Kana) = (userDeviceId, privateMoneyId, callbackUrl, kana);

        private string path { get { return "/user-devices" + "/" + UserDeviceId + "/banks"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

#if NETFRAMEWORK
        public async Task<BankRegisteringInfo> Send(Client client) {
                string res = await client.Send(path, CreateBank.method, this);
                return JsonSerializer.Deserialize<BankRegisteringInfo>(res, client.JsonOptions);
        }
#else
#nullable enable
        public async Task<BankRegisteringInfo?> Send(Client client) {
                string res = await client.Send(path, CreateBank.method, this);
                return JsonSerializer.Deserialize<BankRegisteringInfo>(res, client.JsonOptions);
        }
#endif
    }
}
