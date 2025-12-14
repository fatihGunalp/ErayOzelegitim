using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Crud.Abstracts
{
    internal interface IProductCRUD
    {
        //Create
        public void CreateProduct(Product product);

        //Read
        public void GetProducts();

        //Update
        public void UpdateProduct(Product product);

        //Delete
        public void DeleteProduct(int productId);
    }
}
