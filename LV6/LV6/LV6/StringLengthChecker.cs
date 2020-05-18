using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class StringLengthChecker : StringChecker
    {
        private int stringLength = 5;
        protected override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length < stringLength)
                return false;
            else
                return true;
        }
    }
}
