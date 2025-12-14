using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Crud
{
    internal  class Product : ICreate, IRead, IDelete, IUpdate
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }

        public string Create()
        {
            return "Ürün Oluşturuldu";
        }

        public string Delete()
        {
            return "Ürün Silindi";
        }

        public string Read()
        {
            return "Ürün Okundu";
        }

        public string Update()
        {
            return "Ürün Güncellendi";
        }
    }
}
