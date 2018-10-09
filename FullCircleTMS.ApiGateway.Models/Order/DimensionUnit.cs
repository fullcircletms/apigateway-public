using System.Runtime.Serialization;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public enum DimensionUnit
    {
        [EnumMember(Value = "in")] Inches,
        [EnumMember(Value = "fr")] Feet,
        [EnumMember(Value = "yd")] Yards,
        [EnumMember(Value = "mm")] Millimeters,
        [EnumMember(Value = "cm")] Centimeters,
        [EnumMember(Value = "m")] Meters,
        [EnumMember(Value = "km")] Kilometers,
        [EnumMember(Value = "mi")] Miles,
        [EnumMember(Value = "other")] Other,
    }
}