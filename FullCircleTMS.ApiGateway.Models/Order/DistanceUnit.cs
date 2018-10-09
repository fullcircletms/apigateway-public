using System.Runtime.Serialization;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public enum DistanceUnit
    {
        [EnumMember(Value = "km")] Kilometers,
        [EnumMember(Value = "mi")] Miles,
        [EnumMember(Value = "other")] Other,
    }
}