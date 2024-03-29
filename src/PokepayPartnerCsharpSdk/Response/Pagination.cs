// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class Pagination
    {
        public int Current { get; set; }
        public int PerPage { get; set; }
        public int MaxPage { get; set; }
        public bool HasPrev { get; set; }
        public bool HasNext { get; set; }

        [JsonConstructor]
        public Pagination(int current, int perPage, int maxPage, bool hasPrev, bool hasNext) =>
            (Current, PerPage, MaxPage, HasPrev, HasNext) = (current, perPage, maxPage, hasPrev, hasNext);
    }
}
