using DiscogsHttpClient.Objects.Common;
using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Objects.Marketplace
{
    public class DiscogsSearchResults
    {
        [JsonProperty("results")]
        public DiscogsSearchResultItem[] Results { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}
