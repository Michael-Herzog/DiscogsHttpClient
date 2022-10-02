using DiscogsHttpClient.Objects.Database;

namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// The Community Release Rating endpoint retrieves the average rating and the total number of user ratings for a given release.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-community-release-rating-get
    public class GetCommunityReleaseRatingRequest : DiscogsRequest<DiscogsCommunityReleaseRating>
    {
        public GetCommunityReleaseRatingRequest(string releaseId)
            : base("/releases/{0}/rating", HttpMethod.Get)
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
