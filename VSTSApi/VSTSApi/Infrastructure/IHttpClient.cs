using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VSTSApi.Infrastructure
{
    public interface IHttpClient
    {
        HttpClient Inst { get; }
        Task<string> GetStringAsync(string uri);
        HttpResponseMessage PostAsync<T>(string uri, T item);
    }
}
