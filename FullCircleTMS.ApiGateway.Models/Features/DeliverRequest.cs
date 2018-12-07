using System;

namespace FullCircleTMS.ApiGateway.Models.Features
{
    public class DeliverRequest
    {
        public DateTimeOffset Delivered { get; set; }
        public string ProofOfDeliverySignedBy { get; set; }
        public string Note { get; set; }
    }
}