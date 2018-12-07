using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FullCircleTMS.ApiGateway.Models.Orders
{
    public class Dimensions
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public DimensionUnit Unit { get; set; }
    }
}