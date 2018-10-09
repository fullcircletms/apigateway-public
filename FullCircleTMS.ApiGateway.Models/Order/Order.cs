using System;
using System.Collections.Generic;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public class Order
    {
        public Guid Ref { get; set; }
        public int OrderNumber { get; set; }
        public DateTimeOffset DispatchedDateTime { get; set; }
        public Broker Broker { get; set; }
        public Contact DispatchContact { get; set; }
        public RecommendedVehicle RecommendedVehicle { get; set; }
        public Distance OverrideDistance { get; set; }
        public bool BordersOpen { get; set; }
        public bool DockHigh { get; set; }
        public IList<Note> Notes { get; set; }
        public IList<Stop> Stops { get; set; }
        public IList<Freight> FreightList { get; set; }
    }
}