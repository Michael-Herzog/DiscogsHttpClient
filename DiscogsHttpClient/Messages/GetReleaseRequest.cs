using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Gets a discogs release.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release
    public class GetReleaseRequest : DiscogsRequest<DiscogsRelease>
    {
        public GetReleaseRequest(string releaseId, string currencyCode = "")
            : base("/releases/{0}{1}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(releaseId), currencyCode.HasValue() ? $"?curr_abbr={currencyCode}" : string.Empty);
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
