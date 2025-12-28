using Microsoft.EntityFrameworkCore;
using MVC_CoffeeApplication.Models.Entities;


namespace MVC_CoffeeApplication.Models.Context
{
    public class CoffeeContext:DbContext
    {
        public CoffeeContext()
        {
            
        }

        public CoffeeContext(DbContextOptions<CoffeeContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Coffee> Cofees { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           

        //    string fatihConnection = "server=DESKTOP-J4PTH70;database=CoffeeDb;uid=sa;pwd=123;TrustServerCertificate=True;";

        //    string erayConnection = "server=REVERAN\\SQLEXPRESS;databese=CoffeDb;Trusted_Connection=True;TrustServerCertificate=True;";

        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(fatihConnection);
        //    }

        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Category>()
                .HasMany(x => x.Coffees)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

            //3 adet Category oluştur
            //3 adet kahve oluştur



            modelBuilder.Entity<CoffeeSize>().HasKey(x => new { x.SizeId, x.CoffeeId });

            modelBuilder.Entity<CoffeeSize>()
                .HasOne(x => x.Coffee)
                .WithMany(x => x.CoffeeSizes)
                .HasForeignKey(x => x.CoffeeId);


            modelBuilder.Entity<CoffeeSize>()
               .HasOne(x => x.Size)
               .WithMany(x => x.CoffeeSizes)
               .HasForeignKey(x => x.SizeId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
