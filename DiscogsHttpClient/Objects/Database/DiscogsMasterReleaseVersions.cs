using DiscogsHttpClient.Objects.Common;

namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsMasterReleaseVersions
    {
        [JsonProperty("versions")]
        public DiscogsMasterReleaseVersion[] Versions { get; set; }

        [JsonProperty("pagination")]
        public DiscogsPagination Pagination { get; set; }
    }
}