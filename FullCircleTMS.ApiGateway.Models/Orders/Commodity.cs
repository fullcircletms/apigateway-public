namespace FullCircleTMS.ApiGateway.Models.Orders
{
    public class Commodity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsHazmat { get; set; }
        public Hazmat HazmatDetails { get; set; }
    }
}