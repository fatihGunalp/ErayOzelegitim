using MVC_CoffeeApplication.Models.Context;
using MVC_CoffeeApplication.Models.Entities;
using MVC_CoffeeApplication.Repositories.Abstracts;

namespace MVC_CoffeeApplication.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CoffeeContext _context;

        public CategoryRepository(CoffeeContext context)
        {
            _context = context;
        }




        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}
