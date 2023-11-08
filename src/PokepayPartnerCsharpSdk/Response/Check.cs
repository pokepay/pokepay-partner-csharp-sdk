// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Check
    {
        public string Id { get; }
        public string CreatedAt { get; }
        public double Amount { get; }
        public double MoneyAmount { get; }
        public double PointAmount { get; }
        public string Description { get; }
        public User User { get; }
        public bool IsOnetime { get; }
        public bool IsDisabled { get; }
        public string ExpiresAt { get; }
        public PrivateMoney PrivateMoney { get; }
        public int UsageLimit { get; }
        public double UsageCount { get; }
        public string PointExpiresAt { get; }
        public int PointExpiresInDays { get; }
        public string Token { get; }

        [JsonConstructor]
        public Check(string id, string createdAt, double amount, double moneyAmount, double pointAmount, string description, User user, bool isOnetime, bool isDisabled, string expiresAt, PrivateMoney privateMoney, string token) =>
            (Id, CreatedAt, Amount, MoneyAmount, PointAmount, Description, User, IsOnetime, IsDisabled, ExpiresAt, PrivateMoney, Token) = (id, createdAt, amount, moneyAmount, pointAmount, description, user, isOnetime, isDisabled, expiresAt, privateMoney, token);
    }
}
