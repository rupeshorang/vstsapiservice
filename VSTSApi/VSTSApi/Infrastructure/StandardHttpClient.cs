using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VSTSApi.Infrastructure
{
    public class StandardHttpClient : IHttpClient
    {
        private HttpClient client;
        public HttpClient Inst => client;
        public StandardHttpClient()
        {
            client = new HttpClient();
        }

        public Task<string> GetStringAsync(string uri) =>
            client.GetStringAsync(uri);

        public Task<HttpResponseMessage> PostAsync<T>(string uri, T item)
        {
            var contentString = new StringContent(JsonConvert.SerializeObject(item), System.Text.Encoding.UTF8, "application/json");
            var method = new HttpMethod("POST");

            // send the request               
            var request = new HttpRequestMessage(method, uri) { Content = contentString };
            return client.SendAsync(request);
        }
    }
}
