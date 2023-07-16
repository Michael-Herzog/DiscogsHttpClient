using Discogs.Objects.Database;

namespace Discogs.Messages
{
    /// <summary>
    /// The Release Stats endpoint retrieves the total number of “haves” 
    /// (in the community’s collections) and “wants” (in the community’s wantlists) for a given release.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release-stats-get
    public class GetReleaseStatsRequest : DiscogsRequest<DiscogsReleaseStats>
    {
        public GetReleaseStatsRequest(string releaseId)
            : base("/releases/{0}/stats", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(releaseId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
