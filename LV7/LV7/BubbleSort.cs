using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int j = 0; j <= array.Length ; j++)
            {
                for (int i = 0; i <= array.Length - j - 1; i++)
                {
                    if (array[i] > array[i + 1])
                        Swap(ref array[i + 1], ref array[i]);
                }
            }
        }
    }
}
