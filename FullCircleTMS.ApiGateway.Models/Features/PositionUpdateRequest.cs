using System;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class PositionUpdateRequest
    {
        public DateTimeOffset PositionDateTime { get; set; }
        public GeoPoint GeoPoint { get; set; }
        public double Speed { get; set; }
    }
}