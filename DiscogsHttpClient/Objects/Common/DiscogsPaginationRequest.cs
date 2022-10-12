namespace DiscogsHttpClient.Objects.Common
{
    public class DiscogsPaginationRequest
    {
        /// <summary>
        ///  The page you want to request.
        /// </summary>
        public int? page { get; set; } = 1;

        /// <summary>
        ///  The number of item per page.
        /// </summary>
        public int? per_page { get; set; } = 25;
    }
}
