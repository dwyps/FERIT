using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class Cart : IItem
    {
        private const double DVDTax = 0.18;
        List<IItem> items = new List<IItem>();
        public Cart(List<IItem> items)
        {
            this.items = items;
        }
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double Accept(IVisitor visitor)
        {
            double price = 0;
            foreach (IItem item in items)
                price += item.Accept(visitor);
            return price;     
        }
    }
}
