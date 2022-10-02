using Newtonsoft.Json.Converters;

namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsImage
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("uri150")]
        public string Uri150 { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public DiscogsImageType Type { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public enum DiscogsImageType
    {
        secondary,
        primary
    }
}
