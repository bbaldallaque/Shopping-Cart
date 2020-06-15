using ShoppingCar.Data.Model;
using ShoppingCar.Service.Infraestructure;
using System.Collections.Generic;

namespace ShoppingCar.Service.Repository
{
    public class CategoryRepository : ICategory
    {
        public CategoryRepository(DataContext context)
        {

        }
        public void DeleteCategory(Category category)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategoryById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertCategory(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}
