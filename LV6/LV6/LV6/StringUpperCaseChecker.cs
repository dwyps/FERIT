using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsUpper);
        }
    }
}
