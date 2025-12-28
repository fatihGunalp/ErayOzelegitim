using MVC_CoffeeApplication.Models.Entities;

namespace MVC_CoffeeApplication.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        //Get
        public Category GetCategory(int id);
        //List
        public List<Category> GetAllCategories();
        //Create

        //Update
        //Delete

    }
}
