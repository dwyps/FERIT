using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    public class ConsoleLogger
    {
        private static ConsoleLogger instance;
        private ConsoleLogger()
        {
            
        }
        public static ConsoleLogger getInstance()
        {
            if (instance == null)
                instance = new ConsoleLogger();
            return instance;
        }
        public void log()
        {
            Console.WriteLine("Dataset, time: " + DateTime.Now);
        }
    }
}
