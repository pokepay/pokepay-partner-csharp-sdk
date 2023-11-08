// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateCheck
    {
        #nullable enable
        public double? MoneyAmount { get; set; }
        #nullable enable
        public double? PointAmount { get; set; }
        public string AccountId { get; set; }
        #nullable enable
        public string? Description { get; set; }
        #nullable enable
        public bool? IsOnetime { get; set; }
        #nullable enable
        public int? UsageLimit { get; set; }
        #nullable enable
        public string? ExpiresAt { get; set; }
        #nullable enable
        public string? PointExpiresAt { get; set; }
        #nullable enable
        public int? PointExpiresInDays { get; set; }
        #nullable enable
        public string? BearPointAccount { get; set; }

        public CreateCheck(string accountId) =>
            (AccountId) = (accountId);

        private string path { get { return "/checks"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

        #nullable enable
        public async Task<Check?> Send(Client client) {
            string res = await client.Send(path, CreateCheck.method, this);
            return JsonSerializer.Deserialize<Check>(res, client.JsonOptions);
        }
    }
}
