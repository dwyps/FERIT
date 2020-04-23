using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //7. zadatak
    //U klasu FlexibleDiceRoller dodati metodu koja uklanja samo kockice čiji broj stranica odgovara predanom joj argumentu.

    class FlexibleDiceRoller : IDiceRoller, IDiceChanger
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }
        public void RemoveDie(int number)
        {
            for (int i = dice.Count(); i <= 0; i--)
                if (resultForEachRoll[i] == number)
                    dice.RemoveAt(i);
        }

        public void InsertDie()
        {
            throw new NotImplementedException();
        }
    }
}
