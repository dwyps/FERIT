using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class LinearSearch
    {
        public bool Search(double[] array, double number)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == number)
                    return true;
            return false;
        }
    }
}
