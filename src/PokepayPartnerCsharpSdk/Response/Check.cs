// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Check
    {
        public string Id { get; set; }
        public string CreatedAt { get; set; }
        public double Amount { get; set; }
        public double MoneyAmount { get; set; }
        public double PointAmount { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public bool IsOnetime { get; set; }
        public bool IsDisabled { get; set; }
        public string ExpiresAt { get; set; }
        public string LastUsedAt { get; set; }
        public PrivateMoney PrivateMoney { get; set; }
        public int UsageLimit { get; set; }
        public double UsageCount { get; set; }
        public string PointExpiresAt { get; set; }
        public int PointExpiresInDays { get; set; }
        public string Token { get; set; }

        [JsonConstructor]
        public Check(string id, string createdAt, double amount, double moneyAmount, double pointAmount, string description, User user, bool isOnetime, bool isDisabled, string expiresAt, PrivateMoney privateMoney, string token) =>
            (Id, CreatedAt, Amount, MoneyAmount, PointAmount, Description, User, IsOnetime, IsDisabled, ExpiresAt, PrivateMoney, Token) = (id, createdAt, amount, moneyAmount, pointAmount, description, user, isOnetime, isDisabled, expiresAt, privateMoney, token);
    }
}
