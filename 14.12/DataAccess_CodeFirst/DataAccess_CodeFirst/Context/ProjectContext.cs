using DataAccess_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess_CodeFirst.Context
{
    internal class ProjectContext:DbContext
    {

        public ProjectContext()
        {
            
        }
        //veritabanında tablo haline geelcek olan nesneler.

        //DbSet<> içerisine gödnerilen entity'i veritabanında tablo haline getirir.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //veritabı bağlantı bilgilerini onconfiguring içerisinde tanımlamamız gerekmektedir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ilk başta oluşturmak istediğimiz veritabanı yoksa veritabanını oluştur. Varsa kullanmaya devam et.

            if (!optionsBuilder.IsConfigured)
            {
                //connection string
                string connectionString = "server=DESKTOP-J4PTH70;database=ProductSampleDB;uid=sa;pwd=123;TrustServerCertificate=True;";

                optionsBuilder.UseSqlServer(connectionString);

            }



            base.OnConfiguring(optionsBuilder);
        }

        //Fluent API
    }
}
