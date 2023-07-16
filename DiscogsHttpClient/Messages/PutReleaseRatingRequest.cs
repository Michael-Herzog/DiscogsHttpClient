using Discogs.Objects.Database;

namespace Discogs.Messages
{
    /// <summary>
    /// Gets a discogs user rating for a release.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release-rating-by-user-put
    public class PutReleaseRatingRequest : DiscogsRequest<DiscogsReleaseRating>
    {
        public PutReleaseRatingRequest(string releaseId, string username)
            : base("/releases/{0}/rating/{1}", HttpMethod.Put)
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

        public PutReleaseRatingRequest WithBody(DiscogsReleaseRating discogsReleaseRating)
        {
            Body = discogsReleaseRating;
            return this;
        }
    }
}
