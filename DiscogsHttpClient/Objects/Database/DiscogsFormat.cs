namespace Discogs.Objects.Database
{
    public class DiscogsFormat
    {
        [JsonProperty("descriptions")]
        public string[] Descriptions { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("qty")]
        public string Quantity { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
