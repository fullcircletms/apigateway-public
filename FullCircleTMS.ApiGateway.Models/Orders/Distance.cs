using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FullCircleTMS.ApiGateway.Models.Orders
{
    public class Distance
    {
        public double Value { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public DistanceUnit Unit { get; set; }
    }
}