using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7
{
    class RentVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        public double Visit(DVD DVDItem)
        {
            /*if (DVDItem.Type == DVDType.SOFTWARE)
                return double.NaN;*/
            if (DVDItem.Type == DVDType.SOFTWARE)
                return DVDItem.Price * (1 + DVDTax);
            return DVDItem.Price * 0.1;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * 0.1;
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price * 0.1;
        }
    }
}
