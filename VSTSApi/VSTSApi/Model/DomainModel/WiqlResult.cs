using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model
{
    public class WiqlResult
    {
        [JsonProperty(PropertyName = "workItems")]
        public List<WorkItmes> WorkItems { get; set; }
    }

    public class WorkItmes
    {
        [JsonProperty(PropertyName = "id")]
        public int workItemId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
