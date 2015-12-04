using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SendInBlue
{
    public class ServerResponse
    {
        [JsonProperty("code")]
        public ResponseTypes Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Because SendInBlue return an object on succes or a empty error for other state...
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, JToken> Data { get; set; }
    }
}