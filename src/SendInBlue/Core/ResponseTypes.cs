using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SendInBlue
{
    public enum ResponseTypes
    {
        [EnumMember(Value = "success")]
        Success,

        [EnumMember(Value = "failure")]
        Failure,

        [EnumMember(Value = "error")]
        Error
    }
}
