// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using PokepayPartnerCsharpSdk;
using PokepayPartnerCsharpSdk.Response;

namespace PokepayPartnerCsharpSdk.Request
{
    public class CreateTransferTransaction
    {
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string PrivateMoneyId { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public string? RequestId { get; set; }

        public CreateTransferTransaction(string senderId, string receiverId, string privateMoneyId, double amount) =>
            (SenderId, ReceiverId, PrivateMoneyId, Amount) = (senderId, receiverId, privateMoneyId, amount);

        private string path { get { return "/transactions" + "/transfer"; } }

        private static readonly HttpMethod method = HttpMethod.Post;

        public async Task<Transaction> Send(Client client) {
            string res = await client.Send(path, CreateTransferTransaction.method, this);
            return JsonSerializer.Deserialize<Transaction>(res, client.JsonOptions)!;
        }
    }
}
