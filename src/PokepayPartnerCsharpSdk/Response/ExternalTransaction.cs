// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class ExternalTransaction
    {
        public string Id { get; set; }
        public bool IsModified { get; set; }
        public User Sender { get; set; }
        public Account SenderAccount { get; set; }
        public User Receiver { get; set; }
        public Account ReceiverAccount { get; set; }
        public double Amount { get; set; }
        public string DoneAt { get; set; }
        public string Description { get; set; }

        [JsonConstructor]
        public ExternalTransaction(string id, bool isModified, User sender, Account senderAccount, User receiver, Account receiverAccount, double amount, string doneAt, string description) =>
            (Id, IsModified, Sender, SenderAccount, Receiver, ReceiverAccount, Amount, DoneAt, Description) = (id, isModified, sender, senderAccount, receiver, receiverAccount, amount, doneAt, description);
    }
}
