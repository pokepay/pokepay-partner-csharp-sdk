// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class CpmToken
    {
        [JsonPropertyName("cpm_token")]
        public string Token { get; set; }
        public AccountDetail Account { get; set; }
        public Transaction Transaction { get; set; }
        public ExternalTransaction Event { get; set; }
        public string[] Scopes { get; set; }
        public string ExpiresAt { get; set; }
        public string Metadata { get; set; }

        [JsonConstructor]
        public CpmToken(string token, AccountDetail account, string[] scopes, string expiresAt, string metadata) =>
            (Token, Account, Scopes, ExpiresAt, Metadata) = (token, account, scopes, expiresAt, metadata);
    }
}
