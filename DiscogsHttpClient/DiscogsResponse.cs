using System.Net;
using System.Net.Http.Headers;

namespace Discogs
{
    public class DiscogsResponse
    {
        private readonly object _body;

        public DiscogsResponse(HttpStatusCode status)
        {
            Status = status;
        }

        public DiscogsResponse(HttpStatusCode status, HttpHeaders headers)
        {
            HttpHeaders = headers;
            Status = status;
        }

        public DiscogsResponse(HttpStatusCode status, HttpHeaders headers, object body)
        {
            HttpHeaders = headers;
            Status = status;
            _body = body;
        }

        public HttpStatusCode Status { get; }

        public HttpHeaders HttpHeaders { get; }

        public bool HasBody
            => _body != null;

        public T Body<T>()
            => (T)_body;
    }
}
