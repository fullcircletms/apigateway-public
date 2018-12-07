using System.Net.Http;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class HttpLink
    {
        public string Rel { get; set; }
        public HttpMethod Method { get; set; }
        public string Href { get; set; }

        public HttpLink()
        {
            
        }
        
        public HttpLink(string rel, HttpMethod method, string href)
        {
            Rel = rel;
            Method = method;
            Href = href;
        }
    }
}