namespace Discogs.Objects.Database
{
    public class DiscogsFormat
    {
        [JsonProperty("descriptions")]
        public string[] Descriptions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("qty")]
        public int Quantity { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
