using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak
            /*List<Note> notes = new List<Note>();
            notes.Add(new Note("Note1", "text1"));
            notes.Add(new Note("Note2", "text2"));
            notes.Add(new Note("Note3", "text3"));
            Notebook notebook = new Notebook(notes);
            Iterator iterator = new Iterator(notebook);
            for (Note note = iterator.First(); !iterator.IsDone; note = iterator.Next())
                note.Show();*/

            //4.zadatak
           /*BankAccount bankAccount = new BankAccount("Ime", "Adresa", 0);
            SecondCareTaker careTaker = new SecondCareTaker();*/

            //5.zadatak
            /*AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");
            logger.SetNextLogger(fileLogger);
            logger.Log("message", MessageType.ERROR);*/
            
            //6.zadatak
            StringDigitChecker stringDigitChecker = new StringDigitChecker();
            StringLengthChecker stringLengthChecker = new StringLengthChecker();
            StringUpperCaseChecker stringUpperCaseChecker = new StringUpperCaseChecker();
            StringLowerCaseChecker stringLowerCaseChecker = new StringLowerCaseChecker();

            /*stringDigitChecker.SetNext(stringLengthChecker);
            stringLengthChecker.SetNext(stringUpperCaseChecker);
            stringUpperCaseChecker.SetNext(stringLowerCaseChecker);

            Console.WriteLine(stringDigitChecker.Check("abc12"));*/

            PasswordValidator validator = new PasswordValidator(stringDigitChecker);
            validator.AddChecker(stringLengthChecker);
            validator.AddChecker(stringUpperCaseChecker);
            validator.AddChecker(stringLowerCaseChecker);

            Console.WriteLine(stringDigitChecker.Check("abc12"));
        }
    }
}
