using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class CareTaker
    {
        List<Memento> PreviousStates;
        public CareTaker()
        {
            List<Memento> PreviousStates = new List<Memento>();
        }
        public void AddState(Memento memento)
        {
            PreviousStates.Add(memento);
        }
        public Memento LoadState(int index)
        {
            return PreviousStates[index];
        }
    }
}
