namespace Discogs.Messages
{
    public abstract class DiscogsEntity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
