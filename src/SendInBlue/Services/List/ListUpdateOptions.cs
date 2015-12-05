using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class ListUpdateOptions
    {
        [JsonProperty("list_name")]
        public string Name { get; set; }

        [JsonProperty("list_parent")]
        public int Parent { get; set; }
    }
}
