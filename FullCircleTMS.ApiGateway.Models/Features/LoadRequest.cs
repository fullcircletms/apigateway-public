using System;
using System.Collections.Generic;
using FullCircleTMS.ApiGateway.Models.Orders;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class LoadRequest
    {
        public DateTimeOffset Loaded { get; set; }
        public List<LoadBillOfLading> LoadedBillOfLadings { get; set; }
        public string Note { get; set; }
    }
    
    public class LoadBillOfLading
    {
        public Guid BillOfLadingRef { get; set; }
        public string BillOfLadingReferenceNumber { get; set; }
        
        public double Pieces { get; set; }
        public string PieceUnit { get; set; }
        
        public double Weight { get; set; }
        public WeightUnit WeightUnit { get; set; }
        
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public DimensionUnit DimensionUnit { get; set; }
    }
}