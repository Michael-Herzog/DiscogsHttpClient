namespace DiscogsHttpClient.Objects.Database
{
    public class DiscogsArtistRelease
    {
        [JsonProperty("realname")]
        public string Realname { get; set; }

        [JsonProperty("main_release")]
        public int MainRelease { get; set; }

        [JsonProperty("ResourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
