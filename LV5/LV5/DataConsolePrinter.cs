using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LV5
{
    public class DataConsolePrinter
    {
        public void PrintData(IDataset data)
        {
            ReadOnlyCollection<List<string>> collection = data.GetData();
            foreach (List<String> list in collection)
            {
                foreach (string item in list)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
