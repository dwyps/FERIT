using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    public class ShippingService 
    {
        private double PricePerWeight = 50;
        public double ShippingPrice(IShipable items)
        {
            return items.Weight * PricePerWeight;
        }
    }
}
