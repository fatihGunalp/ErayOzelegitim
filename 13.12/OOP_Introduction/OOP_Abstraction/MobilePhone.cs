using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal class MobilePhone : Product
    {
       

        //Telefon ürünlerinde %5 indirim

        private decimal _unitPrice;
        public override decimal UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = (value * 0.95m);
            }
        }

        public override string ProductDetails()
        {
            return ProductName + " " + _unitPrice;
        }
    }
}
