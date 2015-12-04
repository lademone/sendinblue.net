using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class UserGetResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The list id(s) to be linked from user [Optional].
        /// </summary>
        [JsonProperty("listid")]
        public List<int> ListId { get; set; }

        /// <summary>
        /// This is used to blacklist/ Unblacklist a user
        /// </summary>
        [JsonProperty("blacklisted")]
        [JsonConverter(typeof(BooleanConverter))]
        public bool Blacklisted { get; set; }

        /// <summary>
        /// This is used to blacklist/ Unblacklist a user’s SMS number.
        /// </summary>
        [JsonProperty("blacklisted_sms")]
        [JsonConverter(typeof(BooleanConverter))]
        public bool BlacklistedSMS { get; set; }

        /// <summary>
        /// The name of attribute present in your SendinBlue account.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }
    }
}
