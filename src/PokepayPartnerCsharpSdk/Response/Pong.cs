// DO NOT EDIT: File is generated by code generator.
#nullable enable
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Pong
    {
        [JsonPropertyName("pong")]public string _Pong { get; }

        [JsonConstructor]
        public Pong(string pong) =>
            (_Pong) = (pong);
    }
}
