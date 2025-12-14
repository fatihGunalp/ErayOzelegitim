using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_CodeFirst.Entities
{
    internal class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        //bir kategorinin birden fazla ürünü olur.

        public List<Product> Products { get; set; }

       
    }
}
