using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FullCircleTMS.ApiGateway.Models.Order
{
    public class Stop
    {
        public Guid Ref { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public StopType Type { get; set; } 
        
        public DateTimeOffset ScheduledDateTime { get; set; }
        public DateTimeOffset? EarliestDateTime { get; set; }
        public DateTimeOffset? LatestDateTime { get; set; }
        public string Timezone { get; set; }
        public string Verb { get; set; }
        public IList<Note> Notes { get; set; }
        public StopLocation Location { get; set; }
        public IList<Guid> FreightRefs { get; set; }
    }
}