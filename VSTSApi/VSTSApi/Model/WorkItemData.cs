using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model
{
    public class WorkItemData
    {
        public string Description { get; set; }
        public int TicketId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DateOfFirstUpdate { get; set; }
        public DateTime ClosedDate { get; set; }
        public bool SLAMeet { get; set; }
        public int Priority { get; set; }
        public string AssignedTo { get; set; }
        public string State { get; set; }
    }

    public class TfsTasks
    {
        [JsonProperty(PropertyName = "workItems")]
        public IEnumerable<WorkItemData> WorkItemData { get; set; }
    }
}
