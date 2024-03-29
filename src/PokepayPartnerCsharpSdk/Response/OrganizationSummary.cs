// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class OrganizationSummary
    {
        public int Count { get; set; }
        public double MoneyAmount { get; set; }
        public int MoneyCount { get; set; }
        public double PointAmount { get; set; }
        public double RawPointAmount { get; set; }
        public double CampaignPointAmount { get; set; }
        public int PointCount { get; set; }

        [JsonConstructor]
        public OrganizationSummary(int count, double moneyAmount, int moneyCount, double pointAmount, double rawPointAmount, double campaignPointAmount, int pointCount) =>
            (Count, MoneyAmount, MoneyCount, PointAmount, RawPointAmount, CampaignPointAmount, PointCount) = (count, moneyAmount, moneyCount, pointAmount, rawPointAmount, campaignPointAmount, pointCount);
    }
}
