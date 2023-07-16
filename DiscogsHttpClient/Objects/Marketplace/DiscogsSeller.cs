namespace Discogs.Objects.Marketplace
{
    public class DiscogsSeller : DiscogsEntity
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("payment")]
        public string Payment { get; set; }

        [JsonProperty("stats")]
        public DiscogsStats Stats { get; set; }
    }
}
