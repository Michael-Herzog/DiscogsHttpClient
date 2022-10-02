namespace DiscogsHttpClient
{
    public class DiscogsException : Exception
    {
        public DiscogsException(string message, DiscogsResponse response)
        {
        }

        public DiscogsException(string message)
        {
        }
    }
}
