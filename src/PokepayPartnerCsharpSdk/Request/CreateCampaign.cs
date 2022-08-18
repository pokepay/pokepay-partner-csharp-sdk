// DO NOT EDIT: File is generated by code generator.
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateCampaign
    {
        public string Name { get; set; }
        public string PrivateMoneyId { get; set; }
        public string StartsAt { get; set; }
        public string EndsAt { get; set; }
        public int Priority { get; set; }
        public string Event { get; set; }
        public string BearPointShopId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string PointExpiresAt { get; set; }
        public int PointExpiresInDays { get; set; }
        public bool IsExclusive { get; set; }
        public string Subject { get; set; }
        public object[] AmountBasedPointRules { get; set; }
        public object[] ProductBasedPointRules { get; set; }
        public int[] ApplicableDaysOfWeek { get; set; }
        public object[] ApplicableTimeRanges { get; set; }
        public string[] ApplicableShopIds { get; set; }
        public int MinimumNumberForCombinationPurchase { get; set; }
        public string DestPrivateMoneyId { get; set; }

        public CreateCampaign(string name, string privateMoneyId, string startsAt, string endsAt, int priority, string eventType) =>
            (Name, PrivateMoneyId, StartsAt, EndsAt, Priority, Event) = (name, privateMoneyId, startsAt, endsAt, priority, eventType);

        private string path { get { return "/campaigns"; } }

        private static readonly HttpMethod method = new HttpMethod("POST");

        public async Task<Campaign> Send(Client client) {
            string res = await client.Send(path, CreateCampaign.method, this);
            return JsonSerializer.Deserialize<Campaign>(res, client.JsonOptions);
        }
    }
}