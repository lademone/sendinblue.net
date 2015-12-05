using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class FolderGetAllOptions
    {
        /// <summary>
        /// Maximum number of records per request is 50, if there are more than 50 folders then you can use this parameter to get next 50 results [Mandatory]
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// This should be a valid number between 1-50 [Mandatory]
        /// </summary>
        [JsonProperty("page_limit")]
        public int PageLimit { get; set; }
    }
}
