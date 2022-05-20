// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedAccounts
    {
        public Account[] Rows { get; }
        public int Count { get; }
        public Pagination Pagination { get; }

        [JsonConstructor]
        public PaginatedAccounts(Account[] rows, int count, Pagination pagination) =>
            (Rows, Count, Pagination) = (rows, count, pagination);
    }
}
