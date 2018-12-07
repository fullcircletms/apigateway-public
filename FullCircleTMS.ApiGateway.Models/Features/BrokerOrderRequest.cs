using System;
using System.Collections;
using System.Collections.Generic;
using FullCircleTMS.ApiGateway.Models.Orders;
    
namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class BrokerOrderRequest
    {
        public Guid RequestID { get; set; } = Guid.NewGuid();
        
        public Order Order { get; set; }
        public string Signature { get; set; }
        public IEnumerable<HttpLink> Links { get; set; }
        public IEnumerable<HttpLink> Commands { get; set; }
    }

    public class BrokerOrderResponse
    {
        public bool Accepted { get; set; }
        public string Note { get; set; }
    }
}