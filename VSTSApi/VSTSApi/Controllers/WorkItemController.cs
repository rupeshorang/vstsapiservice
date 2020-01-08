using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<WorkItemData> Get(string project)
        {
            var proj = project ?? settings.Value.Project;
            var workItemId = workItemService.GetWorkItemId(proj);
            IList<WorkItemRoot> workItems = new List<WorkItemRoot>();
            if(workItemId!=null)
            {
                foreach(var id in workItemId)
                {
                    workItems.Add(workItemService.GetWorkItem(id.ToString(), proj));
                }
            }

            return new List<WorkItemData>();
        }

        // GET: api/WorkItem/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

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
    }
}
