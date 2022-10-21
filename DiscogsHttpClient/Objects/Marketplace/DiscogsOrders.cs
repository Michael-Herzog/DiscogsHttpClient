using DiscogsHttpClient.Objects.Common;

namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsOrders
    {
        [JsonProperty("orders")]
        public DiscogsOrderItem[] Release { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}
