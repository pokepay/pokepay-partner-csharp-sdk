// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class TransactionDetail
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public bool IsModified { get; set; }
        public User Sender { get; set; }
        public Account SenderAccount { get; set; }
        public User Receiver { get; set; }
        public Account ReceiverAccount { get; set; }
        public double Amount { get; set; }
        public double MoneyAmount { get; set; }
        public double PointAmount { get; set; }
        public double RawPointAmount { get; set; }
        public double CampaignPointAmount { get; set; }
        public string DoneAt { get; set; }
        public string Description { get; set; }
        public Transfer[] Transfers { get; set; }

        [JsonConstructor]
        public TransactionDetail(string id, string type, bool isModified, User sender, Account senderAccount, User receiver, Account receiverAccount, double amount, double moneyAmount, double pointAmount, double rawPointAmount, double campaignPointAmount, string doneAt, string description, Transfer[] transfers) =>
            (Id, Type, IsModified, Sender, SenderAccount, Receiver, ReceiverAccount, Amount, MoneyAmount, PointAmount, RawPointAmount, CampaignPointAmount, DoneAt, Description, Transfers) = (id, type, isModified, sender, senderAccount, receiver, receiverAccount, amount, moneyAmount, pointAmount, rawPointAmount, campaignPointAmount, doneAt, description, transfers);
    }
}
