using Discogs.Objects.Common;

namespace Discogs.Objects.Marketplace
{
    public class DiscogsOrders
    {
        [JsonProperty("orders")]
        public DiscogsOrder[] Orders { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}
