using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Gets a discogs user rating for a release.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release-rating-by-user
    public class GetReleaseRatingRequest : DiscogsRequest<DiscogsReleaseRating>
    {
        public GetReleaseRatingRequest(string releaseId, string username)
            : base("/releases/{0}/rating/{1}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(releaseId), Uri.EscapeDataString(username));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
