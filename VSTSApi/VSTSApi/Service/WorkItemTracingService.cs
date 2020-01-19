using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using VSTSApi.Infrastructure;
using VSTSApi.Model;

namespace VSTSApi.Service
{
    public class WorkItemTracingService : IWorkItemTrackingService
    {
        private IHttpClient apiClient;
        private readonly string remoteServiceBaseUrl;
        private readonly IOptionsSnapshot<AppSettings> settings;

        public WorkItemTracingService(IOptionsSnapshot<AppSettings> settings, IHttpClient client)
        {
            this.settings = settings;
            this.apiClient = client;
            this.remoteServiceBaseUrl = settings.Value.VstsUrl;
        }

        public WorkItemRoot GetWorkItem(string id, string projectName = null)
        {
            var credential = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", settings.Value.Token)));
            apiClient.Inst.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credential);
            var workItemUrl = $"{remoteServiceBaseUrl}/{projectName}/_apis/wit/workItems?id={id}";
            var response = apiClient.GetStringAsync(workItemUrl).Result;
            return JsonConvert.DeserializeObject<WorkItemRoot>(response);
        }

        public IList<int> GetWorkItemId(string projectName, string userName = null)
        {
            IList<int> ids = new List<int>();
            var credential = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(string.Format("{0}:{1}", "", settings.Value.Token)));
            apiClient.Inst.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credential);
            var workItemUrl = $"{remoteServiceBaseUrl}/{projectName}/_apis/wit/wiql?api-version=5.1";
            var response = apiClient.PostAsync(workItemUrl, GetWorkItemQuery(projectName, userName));
            response.EnsureSuccessStatusCode();
            var stream = response.Content.ReadAsStreamAsync().Result;
            StreamReader reader = new StreamReader(stream);
            var result = JsonConvert.DeserializeObject<WiqlResult>(reader.ReadToEnd().ToString());
            foreach (var items in result.WorkItems)
            {
                ids.Add(items.workItemId);
            }

            return ids;
        }

        private Object GetWorkItemQuery(string project, string user = null, bool excludeClosed = true)
        {
            //Object wiql = new
            //{
            //    query = "Select [State], [Title] " +
            //            "From WorkItems " +
            //            "Where [System.TeamProject] = '" + project + "' " +
            //            "And [System.AssignedTo] = '" + user + "' "
            //};

            Object wiql = new
            {
                query = "Select [System.Id] " +
                        "From WorkItems " +
                        "Where [System.TeamProject] = 'MyFirstProject' "
            };

            return wiql;
        }
    }
}
