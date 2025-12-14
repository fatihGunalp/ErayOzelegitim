using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Crud
{
    internal class Product 
    {

        //bir ürünün ...'sı olur.
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }

        
        //bir ürünün bir adet kategorisi olur.
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{ID} {ProductName} {UnitPrice} {Category.CategoryName}";
        }

    }
}
