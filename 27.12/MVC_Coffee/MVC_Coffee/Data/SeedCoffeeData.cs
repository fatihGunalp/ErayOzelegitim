using MVC_Coffee.Models.Entities;

namespace MVC_Coffee.Data
{
    public class SeedCoffeeData
    {


        public static List<Coffee> coffees = new List<Coffee>
        {
            //1 Filtre kahve
            new FilterCoffee{ID=1, Name="Colombia Filter", Price=100m, BeanOrigin="Colombia"},

            //2 Espresso
            new Espresso{ID=2, Name="Single Espresso",Price=120, ShotCount=1},
            new Espresso{ID=3, Name="Double Espresso",Price=150, ShotCount=2},
            //2 Latte
            new Latte{ID=4, Name="Classic Latte",MilkType="Laktozsuz",Price=110},
             new Latte{ID=5, Name="Vanilla Latte",MilkType="Badem sütü",Price=120},
        };

    }
}
