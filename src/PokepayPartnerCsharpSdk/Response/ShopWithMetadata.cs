// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class ShopWithMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OrganizationCode { get; set; }
        public string Status { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string ExternalId { get; set; }

        [JsonConstructor]
        public ShopWithMetadata(string id, string name, string organizationCode, string status) =>
            (Id, Name, OrganizationCode, Status) = (id, name, organizationCode, status);
    }
}
