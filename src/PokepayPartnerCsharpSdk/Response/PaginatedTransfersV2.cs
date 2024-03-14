// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedTransfersV2
    {
        public Transfer[] Rows { get; set; }
        public int PerPage { get; set; }
        public int Count { get; set; }
        public string NextPageCursorId { get; set; }
        public string PrevPageCursorId { get; set; }

        [JsonConstructor]
        public PaginatedTransfersV2(Transfer[] rows, int perPage, int count) =>
            (Rows, PerPage, Count) = (rows, perPage, count);
    }
}
