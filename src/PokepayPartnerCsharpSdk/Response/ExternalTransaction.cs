// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class ExternalTransaction
    {
        public string Id { get; }
        public bool IsModified { get; }
        public User Sender { get; }
        public Account SenderAccount { get; }
        public User Receiver { get; }
        public Account ReceiverAccount { get; }
        public double Amount { get; }
        public string DoneAt { get; }
        public string Description { get; }

        [JsonConstructor]
        public ExternalTransaction(string id, bool isModified, User sender, Account senderAccount, User receiver, Account receiverAccount, double amount, string doneAt, string description) =>
            (Id, IsModified, Sender, SenderAccount, Receiver, ReceiverAccount, Amount, DoneAt, Description) = (id, isModified, sender, senderAccount, receiver, receiverAccount, amount, doneAt, description);
    }
}
