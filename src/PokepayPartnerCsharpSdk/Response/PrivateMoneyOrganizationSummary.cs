// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PrivateMoneyOrganizationSummary
    {
        public string OrganizationCode { get; }
        public OrganizationSummary Topup { get; }
        public OrganizationSummary Payment { get; }

        [JsonConstructor]
        public PrivateMoneyOrganizationSummary(string organizationCode, OrganizationSummary topup, OrganizationSummary payment) =>
            (OrganizationCode, Topup, Payment) = (organizationCode, topup, payment);
    }
}
