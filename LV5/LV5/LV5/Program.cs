using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Dataset data = new Dataset("CSV.txt");
            DataConsolePrinter printer = new DataConsolePrinter(data);
            printer.PrintData(data);

            LoggingProxyDataset loggingProxyDataset = new LoggingProxyDataset("CSV.txt");
            loggingProxyDataset.GetData();*/

            DarkTheme darkTheme = new DarkTheme();
            ReminderNote note = new ReminderNote("message", darkTheme);
            //note.Show();

            GroupNote groupNote = new GroupNote("message", darkTheme);
            groupNote.AddName("A");
            //groupNote.Show();

            Notebook notebook = new Notebook(darkTheme);
            notebook.AddNote(note);
            notebook.AddNote(groupNote);
            notebook.Display();
        }
    }
}
