using System.Runtime.Serialization;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public enum StopType
    {
        [EnumMember(Value = "pickup")] Pickup,
        [EnumMember(Value = "delivery")] Delivery,
        [EnumMember(Value = "other")] Other,
    }
}