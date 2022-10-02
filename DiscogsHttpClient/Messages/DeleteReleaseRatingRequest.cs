namespace DiscogsHttpClient.Messages
{
    /// <summary>
    /// Deletes a discogs user rating for a release. Doesn't return anything.
    /// </summary>
    /// https://www.discogs.com/developers/accessing.html#page:database,header:database-release-rating-by-user-delete
    public class DeleteReleaseRatingRequest : DiscogsRequest<object>
    {
        public DeleteReleaseRatingRequest(string releaseId, string username)
            : base("/releases/{0}/rating/{1}", HttpMethod.Delete)
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
