using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double[] sequence = new double[] { 1, 4, 3, 2};
            NumberSequence numberSequence = new NumberSequence(sequence);
            BubbleSort bubbleSort = new BubbleSort();
            numberSequence.SetSortStrategy(bubbleSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());*/

            /*
            SystemDataProvider dataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("file.txt");
            dataProvider.Attach(consoleLogger);
            dataProvider.Attach(fileLogger);
            while (true)
            {
                dataProvider.GetAvailableRAM();
                dataProvider.GetCPULoad();
                System.Threading.Thread.Sleep(1000);
            }
            */

            List<IItem> items = new List<IItem>();
            items.Add(new DVD("dvd", DVDType.MOVIE, 30));
            items.Add(new VHS("vhs", 15));
            items.Add(new Book("book", 40));
            Cart cart = new Cart(items);
            BuyVisitor buyVisitor = new BuyVisitor();
            RentVisitor rentVisitor = new RentVisitor();
            Console.WriteLine(cart.Visit(buyVisitor));
            Console.WriteLine(cart.Visit(rentVisitor));
        }
    }
}
