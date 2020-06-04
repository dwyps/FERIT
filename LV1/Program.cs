using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            Note Note1 = new Note("My first note.", "S.T.", 2);
            Note Note2 = new Note("My second note.", "S.T.");
            Note Note3 = new Note();
            Console.WriteLine("{0}, {1}", Note1.getText(), Note1.getAuthor());
            Console.WriteLine("{0}, {1}", Note2.getText(), Note2.getAuthor());
            Console.WriteLine("{0}, {1}", Note3.getText(), Note3.getAuthor());

            NoteWithTime Note4 = new NoteWithTime();

            ToDoList Tasks = new ToDoList();

            Tasks.AddNote(Note4);

            Console.WriteLine(Tasks.getStringRepresentation());

            for(int i = 0; i < 3; i++)
            {
                string text = Console.ReadLine();
                string author = Console.ReadLine();
                int importance = Convert.ToInt32(Console.ReadLine());
                Tasks.AddNote(new Note(text, author, importance));
            }

            Console.WriteLine(Tasks.getStringRepresentation());

            Tasks.RemoveNotesWithHighestImportance();

            Console.WriteLine(Tasks.getStringRepresentation());
        }
    }
}
