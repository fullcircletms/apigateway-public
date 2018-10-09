using System.Runtime.Serialization;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public enum WeightUnit
    {
        [EnumMember(Value = "lb")] Pounds,
        [EnumMember(Value = "kg")] Kilograms,
        [EnumMember(Value = "sht")] ShortTon,
        [EnumMember(Value = "t")] Tonne,
        [EnumMember(Value = "other")] Other,
    }
}