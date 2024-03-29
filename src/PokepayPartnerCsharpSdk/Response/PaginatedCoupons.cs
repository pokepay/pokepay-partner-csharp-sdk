// DO NOT EDIT: File is generated by code generator.
using System.Text.Json.Serialization;

namespace PokepayPartnerCsharpSdk.Response
{
    public class PaginatedCoupons
    {
        public Coupon[] Rows { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }

        [JsonConstructor]
        public PaginatedCoupons(Coupon[] rows, int count, Pagination pagination) =>
            (Rows, Count, Pagination) = (rows, count, pagination);
    }
}
