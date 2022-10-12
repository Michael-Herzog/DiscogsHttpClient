using DiscogsHttpClient.Objects.Common;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsGetArtistReleasesRequestMessage : DiscogsPaginationRequest
    {
        [JsonProperty("sort")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ArtistReleasesSort SortBy { get; set; }

        [JsonProperty("sort_order")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DiscogsSortOrder SortOrder { get; set; }
    }

    public enum ArtistReleasesSort
    {
        [EnumMember(Value = "year")]
        Year,

        [EnumMember(Value = "title")]
        Title,

        [EnumMember(Value = "format")]
        Format
    }
}