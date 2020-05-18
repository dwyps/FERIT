using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class SecondMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAdress { get; private set; }
        public decimal Balance { get; private set; }
        
        public SecondMemento(string ownerName, string ownerAdress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAdress = ownerAdress;
            this.Balance = balance;
        }
    }
}
