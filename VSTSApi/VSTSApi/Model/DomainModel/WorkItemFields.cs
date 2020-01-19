using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model
{
    public class WorkItemFields
    {
        [JsonProperty(PropertyName = "System.AreaPath")]
        public string AreaPath { get; set; }

        [JsonProperty(PropertyName = "System.TeamProject")]
        public string TeamProject { get; set; }

        [JsonProperty(PropertyName = "System.IterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty(PropertyName = "System.WorkItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty(PropertyName = "System.State")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "System.Reason")]
        public string Reason { get; set; }

        [JsonProperty(PropertyName = "System.CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty(PropertyName = "System.CreatedBy")]
        public UserDetails CreatedBy { get; set; }

        [JsonProperty(PropertyName = "System.ChangedDate")]
        public DateTime ChangedDate { get; set; }

        [JsonProperty(PropertyName = "System.ChangedBy")]
        public UserDetails ChangedBy { get; set; }

        [JsonProperty(PropertyName = "System.Title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.Effort")]
        public int SchedulingEffort { get; set; }

        [JsonProperty(PropertyName = "System.Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "System.AssignedTo")]
        public UserDetails AssignedTo { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.RemainingWork")]
        public int SchedulingRemainingWork { get; set; }

        [JsonProperty(PropertyName = "System.Tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.OriginalEstimate")]
        public string OriginalEstimate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.CompletedWork")]
        public string CompletedWork { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ActivatedDate")]
        public DateTime ActivatedDate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ActivatedBy")]
        public UserDetails ActivatedBy { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ClosedDate")]
        public DateTime ClosedDate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ClosedBy")]
        public UserDetails ClosedBy { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.Priority")]
        public string Priority { get; set; }
    }
}
