// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class UnpermittedAdminUser
    {
        public string Type { get; }
        public string Message { get; }

        [JsonConstructor]
        public UnpermittedAdminUser(string type, string message) =>
            (Type, Message) = (type, message);
    }
}