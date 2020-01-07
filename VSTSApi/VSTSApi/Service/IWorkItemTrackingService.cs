using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VSTSApi.Model;

namespace VSTSApi.Service
{
    public interface IWorkItemTrackingService
    {
        WorkItemRoot GetWorkItem(string id, string projectName = null);

        IList<int> GetWorkItemId(string userName, string projectName);
    }
}
