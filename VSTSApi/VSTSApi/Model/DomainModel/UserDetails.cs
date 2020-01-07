using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSTSApi.Model
{
    public class UserDetails
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "displayName")]
        public string  UserName { get; set; }

        [JsonProperty(PropertyName = "uniqueName")]
        public string UserUniqueName { get; set; }
    }
}
