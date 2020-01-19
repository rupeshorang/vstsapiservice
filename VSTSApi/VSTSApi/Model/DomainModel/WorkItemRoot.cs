using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model
{
    public class WorkItemRoot
    {
        [JsonProperty(PropertyName = "id")]
        public int TicketId { get; set; }

        [JsonProperty(PropertyName = "rev")]
        public int Rev { get; set; }

        [JsonProperty(PropertyName = "fields")]
        public WorkItemFields Fields { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
