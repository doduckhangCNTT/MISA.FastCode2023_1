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
    internal class MRequired : ValidationAttribute
    {


        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString().Replace(" ", "")))
            {
                throw new ValidateException(44, Resource1.notAllowNull);
            }
            return true;
        }

    }
}
