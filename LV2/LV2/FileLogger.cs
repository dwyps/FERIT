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
    class FileLogger : ILogger
    {
        private string filePath;
        /*public void Log(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }*/
        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
