using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumReturnString.Enums
{
    public enum Colors
    {
        [Description("Red")]
        Red = 1,
        [Description("Green")]
        Green = 2
    }
}
