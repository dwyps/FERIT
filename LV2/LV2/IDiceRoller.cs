using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    //6. zadatak
    /*
        Razlomiti sučelje iz primjera 6 na dva manja sučelja. Izmijeniti klase FlexibleDiceRoller i ClosedDiceRoller
        tako da ugrađuju samo potrebna im sučelja.
        */
    interface IDiceRoller
    {
        void RollAllDice();
    }
}
