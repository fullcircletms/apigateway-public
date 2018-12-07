using System;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class ArriveRequest
    {
        public DateTimeOffset Arrived { get; set; }
        public string Note { get; set; }
        
        // TODO: reason late
        // TODO: geopoint
    }
}