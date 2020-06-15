using ShoppingCar.Data.Model;
using System.Collections.Generic;

namespace ShoppingCar.Service.Infraestructure
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int Id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();
    }
}
