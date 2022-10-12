using DiscogsHttpClient.Objects.Common;

namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsLabelReleases
    {
        [JsonProperty("releases")]
        public DiscogsLabelRelease[] Releases { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}