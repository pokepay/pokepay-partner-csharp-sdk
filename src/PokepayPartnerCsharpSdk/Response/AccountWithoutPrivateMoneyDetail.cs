// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class AccountWithoutPrivateMoneyDetail
    {
        public string Id { get; }
        public string Name { get; }
        public bool IsSuspended { get; }
        public string Status { get; }
        public string PrivateMoneyId { get; }
        public User User { get; }

        [JsonConstructor]
        public AccountWithoutPrivateMoneyDetail(string id, string name, bool isSuspended, string status, string privateMoneyId, User user) =>
            (Id, Name, IsSuspended, Status, PrivateMoneyId, User) = (id, name, isSuspended, status, privateMoneyId, user);
    }
}
