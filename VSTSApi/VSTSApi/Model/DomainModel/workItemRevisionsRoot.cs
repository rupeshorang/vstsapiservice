using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model.DomainModel
{
    public class workItemRevisionsRoot
    {
        public int count { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "workItemId")]
        public int WorkItemId { get; set; }

        [JsonProperty(PropertyName = "rev")]
        public int Rev { get; set; }

        [JsonProperty(PropertyName = "revisedDate")]
        public DateTime RevisedDate { get; set; }

        [JsonProperty(PropertyName = "revisedBy")]
        public UserDetails RevisedBy { get; set; }
    }
}
