using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();
            for(int i = 0; i < 200; i++)
            {
                //Die die = new Die(6);
                //Die die = new Die(6, randomGenerator);
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }
            diceRoller.RollAllDice();
            IList<int> rollingResults = diceRoller.GetRollingResults();
            foreach(int dice in rollingResults)
            {
                Console.WriteLine(dice);
            }
        }
    }
}
