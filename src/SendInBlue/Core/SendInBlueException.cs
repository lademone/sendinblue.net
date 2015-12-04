using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    [Serializable]
    public class SendInBlueException : ApplicationException
    {
        public ResponseTypes Code { get; set; }

        public SendInBlueException(ResponseTypes code, string message)
            : this(code, message, null)
        {
            
        }

        public SendInBlueException(ResponseTypes code, string message, Exception innerException)
            : base(message, innerException)
        {
            Code = code;
        }
    }
}
