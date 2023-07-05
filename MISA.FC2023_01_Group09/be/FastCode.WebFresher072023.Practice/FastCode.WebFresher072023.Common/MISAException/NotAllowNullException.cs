using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.ComMon.MISAException
{
    public class NotAllowNullException:Exception
    {
        public int ErrorCode { get; set; }
        public string DataInValue { get; set; }
        public NotAllowNullException() { }
        public NotAllowNullException(int errorCode, string dataInValue)
        {
            ErrorCode = errorCode;
            DataInValue= dataInValue;
        }
        public NotAllowNullException(string message) : base(message) { }
        public NotAllowNullException(string message, int errorCode, string dataInValue) : base(message)
        {
            ErrorCode = errorCode;
            DataInValue=dataInValue;
        }

    }
}
