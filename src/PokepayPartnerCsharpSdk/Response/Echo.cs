#nullable enable
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Echo
    {
        public string Status { get; }
        public string Message { get; }

        [JsonConstructor]
        public Echo(string status, string message) =>
            (Status, Message) = (status, message);
    }
}
