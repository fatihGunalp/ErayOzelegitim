using Product_Crud.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Crud.Concretes
{
    internal class ProductCrud : IProductCRUD
    {

        //List
        List<Product> products = new List<Product>();


        public void CreateProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            foreach (Product product in products)
            {
                if (product.ID == productId)
                {
                    products.Remove(product);
                }
            }
        }

        public void GetProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

       

        public void UpdateProduct(Product updatedProduct)
        {
            foreach (var product in products)
            {
                if (product.ID == updatedProduct.ID)
                {
                    product.ProductName = updatedProduct.ProductName;
                    product.UnitPrice= updatedProduct.UnitPrice;
                    product.Category.CategoryName = updatedProduct.Category.CategoryName;



                }

            }
        }
    }
}
