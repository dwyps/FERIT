using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //4. zadatak 
    /*
        Napisati klasu ConsoleLogger i klasu FileLogger koje ugrađuju sučelje iz prethodnog primjera. Izmijeniti klasu
        DiceRoller tako da se može koristiti loggerima koji ugrađuju navedeno sučelje. Ubrizgati ovisnost kroz
        posebnu metodu.
        */

    class ConsoleLogger : ILogger
    {
        //public void Log(string message);
        public void Log(ILogable data)
        {
            Console.WriteLine(data.GetStringRepresentation());
        }
    }
}
