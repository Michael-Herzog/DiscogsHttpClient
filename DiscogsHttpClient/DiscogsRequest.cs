namespace Discogs
{
    public class DiscogsRequest<TMessage> : DiscogsRequest
    {
        public DiscogsRequest(string path, HttpMethod method)
            : base(path, method, typeof(TMessage))
        {
        }
    }

    public class DiscogsRequest : HttpRequestMessage
    {
        public DiscogsRequest(string path, HttpMethod method)
            : this(path, method, typeof(void))
        {
        }

        public DiscogsRequest(string path, HttpMethod method, Type responseType)
        {
            Path = path;
            ResponseType = responseType;
            Method = method;
            ContentEncoding = "identity";
        }

        public string Path { get; set; }
        public object? Body { get; set; }
        public string? ContentType { get; set; }
        public string ContentEncoding { get; set; }
        public Type ResponseType { get; }

        public T Clone<T>() where T : DiscogsRequest
            => (T)MemberwiseClone();
    }
}
