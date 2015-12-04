using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public class UserGetOptions
    {
        /// <summary>
        /// Email address of the user to be created in SendinBlue contacts. Already existing email address of user in the SendinBlue contacts to be modified [Mandatory].
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
