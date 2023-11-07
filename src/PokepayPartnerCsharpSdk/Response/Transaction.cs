// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Transaction
    {
        public string Id { get; }
        public string Type { get; }
        public bool IsModified { get; }
        public User Sender { get; }
        public Account SenderAccount { get; }
        public User Receiver { get; }
        public Account ReceiverAccount { get; }
        public double Amount { get; }
        public double MoneyAmount { get; }
        public double PointAmount { get; }
        public double RawPointAmount { get; }
        public double CampaignPointAmount { get; }
        public string DoneAt { get; }
        public string Description { get; }

        [JsonConstructor]
        public Transaction(string id, string type, bool isModified, User sender, Account senderAccount, User receiver, Account receiverAccount, double amount, double moneyAmount, double pointAmount, double rawPointAmount, double campaignPointAmount, string doneAt, string description) =>
            (Id, Type, IsModified, Sender, SenderAccount, Receiver, ReceiverAccount, Amount, MoneyAmount, PointAmount, RawPointAmount, CampaignPointAmount, DoneAt, Description) = (id, type, isModified, sender, senderAccount, receiver, receiverAccount, amount, moneyAmount, pointAmount, rawPointAmount, campaignPointAmount, doneAt, description);
    }
}
