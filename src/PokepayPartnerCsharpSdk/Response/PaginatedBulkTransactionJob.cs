// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedBulkTransactionJob
    {
        public BulkTransactionJob[] Rows { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }

        [JsonConstructor]
        public PaginatedBulkTransactionJob(BulkTransactionJob[] rows, int count, Pagination pagination) =>
            (Rows, Count, Pagination) = (rows, count, pagination);
    }
}
