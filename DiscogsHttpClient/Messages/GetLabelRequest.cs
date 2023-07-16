using Discogs.Objects.Database;

namespace Discogs.Messages
{
    /// <summary>
    /// The Label resource represents a label, company, recording studio, location, or other entity involved with Artists and Releases. 
    /// Labels were recently expanded in scope to include things that aren’t labels – the name is an artifact of this history.
    /// </summary>
    /// https://www.discogs.com/developers#page:database,header:database-label
    public class GetLabelRequest : DiscogsRequest<DiscogsLabel>
    {
        public GetLabelRequest(string labelId)
            : base("/labels/{0}", HttpMethod.Get)
        {
            try
            {
                Path = Path.FormatInvariant(Uri.EscapeDataString(labelId));
            }
            catch (IOException)
            {
            }

            ContentType = "application/json";
        }
    }
}
