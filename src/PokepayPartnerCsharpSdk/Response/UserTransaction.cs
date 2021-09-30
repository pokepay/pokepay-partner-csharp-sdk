// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class UserTransaction
    {
        public string Id { get; }
        public User User { get; }
        public double Balance { get; }
        public double Amount { get; }
        public double MoneyAmount { get; }
        public double PointAmount { get; }
        public Account Account { get; }
        public string Description { get; }
        public string DoneAt { get; }
        public string Type { get; }
        public bool IsModified { get; }

        [JsonConstructor]
        public UserTransaction(string id, User user, double balance, double amount, double moneyAmount, double pointAmount, Account account, string description, string doneAt, string type, bool isModified) =>
            (Id, User, Balance, Amount, MoneyAmount, PointAmount, Account, Description, DoneAt, Type, IsModified) = (id, user, balance, amount, moneyAmount, pointAmount, account, description, doneAt, type, isModified);
    }
}
