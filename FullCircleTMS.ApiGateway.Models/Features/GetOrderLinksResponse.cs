using System.Collections.Generic;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class GetOrderLinksResponse
    {
        public List<HttpLink> Links { get; set; } = new List<HttpLink>(); 
        public List<HttpLink> Commands { get; set; } = new List<HttpLink>();
    }
}