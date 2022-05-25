// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateShop
    {
        public string ShopName { get; set; }
        public string ShopPostalCode { get; set; }
        public string ShopAddress { get; set; }
        public string ShopTel { get; set; }
        public string ShopEmail { get; set; }
        public string ShopExternalId { get; set; }
        public string OrganizationCode { get; set; }

        public CreateShop(string shopName) =>
            (ShopName) = (shopName);

        private string path { get { return "/shops"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

        public async Task<User> Send(Client client) {
            string res = await client.Send(path, CreateShop.method, this);
            return JsonSerializer.Deserialize<User>(res, client.JsonOptions);
        }
    }
}
