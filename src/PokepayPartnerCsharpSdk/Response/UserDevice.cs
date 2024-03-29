// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class UserDevice
    {
        public string Id { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; }
        public string Metadata { get; set; }

        [JsonConstructor]
        public UserDevice(string id, User user, bool isActive, string metadata) =>
            (Id, User, IsActive, Metadata) = (id, user, isActive, metadata);
    }
}
