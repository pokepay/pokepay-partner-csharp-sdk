// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedTransfers
    {
        public Transfer[] Rows { get; }
        public int Count { get; }
        public Pagination Pagination { get; }

        [JsonConstructor]
        public PaginatedTransfers(Transfer[] rows, int count, Pagination pagination) =>
            (Rows, Count, Pagination) = (rows, count, pagination);
    }
}
