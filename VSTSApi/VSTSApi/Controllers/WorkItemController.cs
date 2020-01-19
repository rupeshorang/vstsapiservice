using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using VSTSApi.Model;
using VSTSApi.Service;

namespace VSTSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemController : ControllerBase
    {
        private readonly IWorkItemTrackingService workItemService;
        private readonly IOptionsSnapshot<AppSettings> settings;

        public WorkItemController(IOptionsSnapshot<AppSettings> settings, IWorkItemTrackingService workItemTrackingService)
        {
            this.settings = settings;
            this.workItemService = workItemTrackingService;
        }
        // GET: api/WorkItem
        [HttpGet]
        public TfsTasks Get(string project)
        {
            var proj = project ?? settings.Value.Project;
            var workItemId = workItemService.GetWorkItemId(proj);
            IList<WorkItemRoot> workItems = new List<WorkItemRoot>();
            List<WorkItemData> items = new List<WorkItemData>();
            if (workItemId != null)
            {
                foreach (var id in workItemId)
                {
                    var data = workItemService.GetWorkItem(id.ToString(), proj);
                    items.Add(
                            new WorkItemData
                            {
                                TicketId = data.TicketId,
                                Description = data.Fields.Description??"",//RemoveHtmlTags(data.Fields.Description),
                                CreatedDate = data.Fields.CreatedDate,
                                DateOfFirstUpdate =data.Fields.ActivatedDate,
                                ClosedDate = data.Fields.ClosedDate==DateTime.MinValue?DateTime.Now:data.Fields.ClosedDate,
                                Priority = Convert.ToInt32(data.Fields.Priority)-1,
                                SLAMeet = GetSLA(data.Fields),
                                State = data.Fields.State
                            }
                        );
                }

                
            }
            return new TfsTasks()
            {
                WorkItemData = items
            };
        }

        //// GET: api/WorkItem/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/WorkItem
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/WorkItem/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private bool GetSLA(WorkItemFields fields)
        {
            return true;
        }

        private string RemoveHtmlTags(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
                return string.Empty;
            return Regex.Replace(html, "<.+?>", string.Empty);
        }
    }
}
