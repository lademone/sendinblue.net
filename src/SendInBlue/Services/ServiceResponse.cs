using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SendInBlue
{
    public class ServiceResponse<T>
    {
        public ResponseTypes Code { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}