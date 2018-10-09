using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public class Weight
    {
        public double Value { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public WeightUnit Unit { get; set; }
    }
}