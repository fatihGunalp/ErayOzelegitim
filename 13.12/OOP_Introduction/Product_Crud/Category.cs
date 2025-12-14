using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Crud
{
    internal class Category:Product,ICreate,IRead,IDelete,IUpdate
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public string Create()
        {
            return "Kategori Oluşturuldu";
        }

        public string Delete()
        {
            return "Kategori Silindi";
        }

        public string Read()
        {
            return "Kategori okundu";
        }

        public string Update()
        {
            return "Kategori Güncellendi";
        }
    }
}
