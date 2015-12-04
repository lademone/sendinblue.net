using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class ListAddUserOptions
    {
        [JsonProperty("users")]
        public List<string> Users { get; set; }
    }
}
