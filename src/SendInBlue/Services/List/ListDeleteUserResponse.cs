using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class ListDeleteUserResponse
    {
        [JsonProperty("success")]
        public Result Success { get; set; }

        [JsonProperty("failed")]
        public Result Failed { get; set; }

        public class Result
        {
            [JsonProperty("users")]
            public List<string> Users { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }
        }
    }
}
