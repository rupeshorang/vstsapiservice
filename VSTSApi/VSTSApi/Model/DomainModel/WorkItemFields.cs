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
        public string SystemAreaPath { get; set; }

        [JsonProperty(PropertyName = "System.TeamProject")]
        public string SystemTeamProject { get; set; }

        [JsonProperty(PropertyName = "System.IterationPath")]
        public string SystemIterationPath { get; set; }

        [JsonProperty(PropertyName = "System.WorkItemType")]
        public string SystemWorkItemType { get; set; }

        [JsonProperty(PropertyName = "System.State")]
        public string SystemState { get; set; }

        [JsonProperty(PropertyName = "System.Reason")]
        public string SystemReason { get; set; }

        [JsonProperty(PropertyName = "System.CreatedDate")]
        public DateTime SystemCreatedDate { get; set; }

        [JsonProperty(PropertyName = "System.CreatedBy")]
        public UserDetails SystemCreatedBy { get; set; }

        [JsonProperty(PropertyName = "System.ChangedDate")]
        public DateTime SystemChangedDate { get; set; }

        [JsonProperty(PropertyName = "System.ChangedBy")]
        public UserDetails SystemChangedBy { get; set; }

        [JsonProperty(PropertyName = "System.Title")]
        public string SystemTitle { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.Effort")]
        public int MicrosoftVSTSSchedulingEffort { get; set; }

        [JsonProperty(PropertyName = "System.Description")]
        public string SystemDescription { get; set; }

        [JsonProperty(PropertyName = "System.AssignedTo")]
        public UserDetails SystemAssignedTo { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.RemainingWork")]
        public int MicrosoftVSTSSchedulingRemainingWork { get; set; }

        [JsonProperty(PropertyName = "System.Tags")]
        public string SystemTags { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.OriginalEstimate")]
        public int MicrosoftVSTSOriginalEstimate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Scheduling.CompletedWork")]
        public int MicrosoftVSTSCompletedWork { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ActivatedDate")]
        public DateTime MicrosoftVSTSActivatedDate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ActivatedBy")]
        public UserDetails ActivatedBy { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ClosedDate")]
        public DateTime MicrosoftVSTSClosedDate { get; set; }

        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.ClosedBy")]
        public UserDetails ClosedBy { get; set; }
    }
}
