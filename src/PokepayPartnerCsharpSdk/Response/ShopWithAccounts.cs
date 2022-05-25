// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class ShopWithAccounts
    {
        public string Id { get; }
        public string Name { get; }
        public string OrganizationCode { get; }
        public string PostalCode { get; }
        public string Address { get; }
        public string Tel { get; }
        public string Email { get; }
        public string ExternalId { get; }
        public ShopAccount[] Accounts { get; }

        [JsonConstructor]
        public ShopWithAccounts(string id, string name, string organizationCode, ShopAccount[] accounts) =>
            (Id, Name, OrganizationCode, Accounts) = (id, name, organizationCode, accounts);
    }
}
