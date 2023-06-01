using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytF1357Model
{
    internal static class ConvertDecimal
    {
        internal static decimal StringToDecimal(string str)
        {
            if (str.Contains("-"))
            {
                string[] newStr = str.Split('-');
                decimal result = decimal.Parse($"-{newStr[1]}") / 100;
                
                return result;
            }
            else
            {
                return decimal.Parse(str) / 100;
            }
        }
    }
}
