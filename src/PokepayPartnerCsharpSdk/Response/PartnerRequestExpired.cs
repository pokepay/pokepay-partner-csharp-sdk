// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PartnerRequestExpired
    {
        public string Type { get; }
        public string Message { get; }

        [JsonConstructor]
        public PartnerRequestExpired(string type, string message) =>
            (Type, Message) = (type, message);
    }
}
