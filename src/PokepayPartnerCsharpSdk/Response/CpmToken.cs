// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class CpmToken
    {
        public string cpm_token { get; }
        public AccountDetail Account { get; }
        public Transaction Transaction { get; }
        public ExternalTransaction Event { get; }
        public string[] Scopes { get; }
        public string ExpiresAt { get; }
        public string Metadata { get; }

        [JsonConstructor]
        public CpmToken(string cpmToken, AccountDetail account, string[] scopes, string expiresAt, string metadata) =>
            (this.cpm_token, Account, Scopes, ExpiresAt, Metadata) = (cpmToken, account, scopes, expiresAt, metadata);
    }
}
