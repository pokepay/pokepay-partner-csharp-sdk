// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class AdminUserWithShopsAndPrivateMoneys
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Organization Organization { get; set; }
        public User[] Shops { get; set; }
        public PrivateMoney[] PrivateMoneys { get; set; }

        [JsonConstructor]
        public AdminUserWithShopsAndPrivateMoneys(string id, string role, string email, string name, bool isActive, Organization organization, User[] shops, PrivateMoney[] privateMoneys) =>
            (Id, Role, Email, Name, IsActive, Organization, Shops, PrivateMoneys) = (id, role, email, name, isActive, organization, shops, privateMoneys);
    }
}
