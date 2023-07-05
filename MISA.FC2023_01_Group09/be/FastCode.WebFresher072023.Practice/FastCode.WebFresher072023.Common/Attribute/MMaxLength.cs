using MISA.QLTS.DEMO.Web04.PXTRUONG.Comon.MISAException;
using MISA.QLTS.DEMO.Web04.PXTRUONG.Comon.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTS.DEMO.Web04.PXTRUONG.Comon.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MMaxLength: ValidationAttribute
    {
        private readonly int _maxLength;

        public MMaxLength(int maxLength)
        {
            _maxLength = maxLength;
        }

        public override bool IsValid(object value)
        {
            long maxValue = (long)Math.Pow(10, _maxLength) - 1;
            if (value is string stringValue && stringValue.Length > _maxLength)
            {
              
                throw new  ValidateException(404, Resource1.maxLength  );
            }
            if (value is int intValue && intValue > maxValue)
            {
                
                throw new ValidateException(404, Resource1.maxLength);
            }
            return true;
        }
    }
}
