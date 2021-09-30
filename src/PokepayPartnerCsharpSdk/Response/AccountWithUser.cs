// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class AccountWithUser
    {
        public string Id { get; }
        public string Name { get; }
        public bool IsSuspended { get; }
        public PrivateMoney PrivateMoney { get; }
        public User User { get; }
        public string? ExternalId { get; }

        [JsonConstructor]
        public AccountWithUser(string id, string name, bool isSuspended, PrivateMoney privateMoney, User user) =>
            (Id, Name, IsSuspended, PrivateMoney, User) = (id, name, isSuspended, privateMoney, user);
    }
}
