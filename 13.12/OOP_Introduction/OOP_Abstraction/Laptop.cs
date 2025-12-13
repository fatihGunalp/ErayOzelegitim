using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class Laptop:Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }


        //Laptop ürünlerinde %10 indirim

        private decimal _unitPrice;
        public override decimal UnitPrice 
        { 
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = (value*0.90m);
            }
        }

        public override string ProductDetails()
        {
            return Brand + " " + Model+" "+_unitPrice;
        }
    }
}
