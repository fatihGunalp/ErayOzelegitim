using MVC_CoffeeApplication.Models.Context;
using MVC_CoffeeApplication.Models.Entities;
using MVC_CoffeeApplication.Repositories.Abstracts;

namespace MVC_CoffeeApplication.Repositories.Concretes
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private readonly CoffeeContext _context;

        public CoffeeRepository(CoffeeContext context)
        {
            _context = context;
        }




        public void CreateCoffee(Coffee coffee)
        {
           _context.Cofees.Add(coffee);
            _context.SaveChanges();
        }

        public List<Coffee> GetAllCoffees()
        {
            return _context.Cofees.ToList();
        }
    }
}
