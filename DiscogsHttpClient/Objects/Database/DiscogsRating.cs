namespace Discogs.Objects.Database
{
    public class DiscogsRating
    {
        [JsonProperty("average")]
        public decimal Average { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
