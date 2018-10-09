namespace FullCircleTMS.ApiGateway.Models.Order
{
    public class Broker
    {
        public string ID { get; set; }
        public string ParentName { get; set; }
        public string BusinessUnitName { get; set; }
        public Address Address { get; set; }
    }
}