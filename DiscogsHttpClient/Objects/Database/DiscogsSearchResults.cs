using Discogs.Objects.Common;
using Discogs.Objects.Database;

namespace Discogs.Objects.Marketplace
{
    public class DiscogsSearchResults
    {
        [JsonProperty("results")]
        public DiscogsSearchResultItem[] Results { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}
