using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_CodeFirst.Entities
{
    internal class Product 
    {

        //bir ürünün ...'sı olur.
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }

        public short UnitsInStock { get; set; }


        public int CategoryId { get; set; }


        //bir ürünün bir adet kategorisi olur.
        public Category Category { get; set; }

        

    }
}
