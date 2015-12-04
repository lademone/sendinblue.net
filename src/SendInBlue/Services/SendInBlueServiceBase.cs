using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public abstract class SendInBlueServiceBase
    {
        protected static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
