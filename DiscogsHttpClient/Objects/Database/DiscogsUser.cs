namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsUser
    {
        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }
    }
}
