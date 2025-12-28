using MVC_CoffeeApplication.Models.Entities;

namespace MVC_CoffeeApplication.Repositories.Abstracts
{
    public interface ICoffeeRepository
    {
        //Get
        //Create
        public void CreateCoffee(Coffee coffee);
        //List
        public List<Coffee> GetAllCoffees();
        //Update
        //Delete

    }
}
