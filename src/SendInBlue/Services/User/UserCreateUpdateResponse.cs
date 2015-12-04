using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class UserCreateUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("updated")]
        public bool Updated { get; set; }
    }
}
