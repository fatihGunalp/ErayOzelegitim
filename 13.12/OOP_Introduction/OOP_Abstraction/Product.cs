using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction
{
    internal abstract class Product//BaseClass
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public abstract decimal UnitPrice { get; set; }

        //Metot
        public abstract string ProductDetails();
    }
}
