using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //Prvi zadatak
    //Kreirajte objekt klase DiceRoller i u njega ubacite 20 kockica. Baciti sve kockice i ispisati rezultate bacanja kockica na ekran.

    //Peti zadatak
    //Izmijenite klasu DiceRoller tako da ugrađuje sučelje ILogable iz prethodnog primjera. Isto tako, izmijeniti
    //klase ConsoleLogger i FileLogger da ugrađuju izmijenjeno sučelje navedenog primjera.

    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;
        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.Roll());
            }
        }

        public IList<int> GetRollingResults()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<int>(this.resultForEachRoll);
        }
        /*
         * 
         * public void LogRollingResults()
        {
            foreach (int result in this.resultForEachRoll)
            {
                logger.Log(result.ToString());
            }
        }*/
        public int DiceCount
        {
            get { return dice.Count; }
        }
        public void setLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public string GetStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Die die in dice)
            {
                stringBuilder.Append(die).Append(", ");
            }
            return stringBuilder.ToString();
        }

    }
}
