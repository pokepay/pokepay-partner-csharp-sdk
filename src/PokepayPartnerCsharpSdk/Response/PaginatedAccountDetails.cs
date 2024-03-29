// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedAccountDetails
    {
        public AccountDetail[] Rows { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }

        [JsonConstructor]
        public PaginatedAccountDetails(AccountDetail[] rows, int count, Pagination pagination) =>
            (Rows, Count, Pagination) = (rows, count, pagination);
    }
}
