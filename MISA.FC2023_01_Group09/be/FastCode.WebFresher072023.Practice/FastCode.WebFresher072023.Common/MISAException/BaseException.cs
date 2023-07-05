using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.Common.MISAException
{
    public class BaseException
    {
        #region proteries
        public int ErroCode { get; set; }
        public string DevMessage { get; set; }
        public string UserMessage { get; set; }
        public string TraceId { get; set; }
        public string MoreInfo { get; set; }
        #endregion
        #region Method
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        #endregion
    }
}
