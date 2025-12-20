using Microsoft.EntityFrameworkCore;

namespace AspNetCore_MVC_Controller.Models
{
    public class Context:DbContext
    {
        //Microsoft.EntityFrameworkCore.SqlServer
        //Microsoft.EntityFrameworkCore.Tools

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string fatihConnection = "server=DESKTOP-J4PTH70;database=Mvcproduct;uid=sa;pwd=123;TrustServerCertificate=True;";

            string erayConnection = "";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(fatihConnection);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Products
            List<Product> products = new List<Product>
            {
                new Product{ID=1,ProductName="Chai",UnitPrice=15},
                new Product{ID=2,ProductName="Chang",UnitPrice=25},
                new Product{ID=3,ProductName="Ikura",UnitPrice=35},

            };

            modelBuilder.Entity<Product>().HasData(products);

            base.OnModelCreating(modelBuilder);
        }
    }
}
