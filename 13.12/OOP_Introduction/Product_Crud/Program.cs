using Product_Crud;
using Product_Crud.Concretes;


//Product Concretes
ProductCrud productCrud = new ProductCrud();

Category categoryBook=new Category();
categoryBook.ID = 1;
categoryBook.CategoryName = "Kitap";




Product product1 = new Product();
product1.ID = 1;
product1.ProductName = "1984";
product1.UnitPrice = 245;
product1.Category = categoryBook;


//Ürün Ekleme
productCrud.CreateProduct(product1);

//Ürün Listeleme
productCrud.GetProducts();





Console.Read();



