using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
     public class Product : IShipable
    {
        private double price;
        private double weight;
        private string description;
        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Price { get { return this.price; } }
        public double Weight { get { return this.weight; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
