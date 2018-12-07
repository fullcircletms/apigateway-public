using System;

namespace FullCircleTMS.ApiGateway.Models.Orders
{
    public class Freight
    {
        public Guid Ref { get; set; }
        public Pieces Pieces { get; set; }
        public Weight Weight { get; set; }
        public Dimensions Dimensions { get; set; }
        public Commodity Commodity { get; set; }
        
        public string BillOfLadingNumber { get; set; }
        public bool Stackable { get; set; }
        
        public Guid PickupStopRef { get; set; }
        public Guid DeliveryStopRef { get; set; }
    }
}