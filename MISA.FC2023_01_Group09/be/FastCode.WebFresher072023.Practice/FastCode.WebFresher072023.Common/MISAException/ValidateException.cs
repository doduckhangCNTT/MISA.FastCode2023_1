using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTS.DEMO.Web04.PXTRUONG.Comon.MISAException
{
    public class ValidateException:Exception
    {
        public int ErrorCode { get; set; }
        public string DataInValue { get; set; }
        public ValidateException() { }
        public ValidateException(int errorCode, string dataInValue)
        {
            ErrorCode = errorCode;
            DataInValue = dataInValue;
        }
        public ValidateException(string message) : base(message) { }
        public ValidateException(string message, int errorCode, string dataInValue) : base(message)
        {
            ErrorCode = errorCode;
            DataInValue = dataInValue;
        }
    }
}
