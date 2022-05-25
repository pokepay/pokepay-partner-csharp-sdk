// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class User
    {
        public string Id { get; }
        public string Name { get; }
        public bool IsMerchant { get; }

        [JsonConstructor]
        public User(string id, string name, bool isMerchant) =>
            (Id, Name, IsMerchant) = (id, name, isMerchant);
    }
}
