using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class PasswordValidator
    {
        StringChecker firstChecker;
        StringChecker lastChecker;
        public PasswordValidator(StringChecker checker)
        {
            this.firstChecker = checker;
            this.lastChecker = firstChecker;
        }
        public void AddChecker(StringChecker checker)
        {
            lastChecker.SetNext(checker);
            this.lastChecker = checker;
        }
        public bool Check(string stringToCheck)
        {
            return firstChecker.Check(stringToCheck);
        }
    }
}
