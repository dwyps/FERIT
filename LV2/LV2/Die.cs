using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //Drugi i treci zadatak 
    //Izmijeniti klasu Die tako da joj se preko konstruktora predaje generator pseudo-slučajnih brojeva. Ponoviti zadatak 1.
    //Izmijeniti klasu Die tako da koristi generator pseudo-slučajnih brojeva iz prethodnog primjera.

    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
