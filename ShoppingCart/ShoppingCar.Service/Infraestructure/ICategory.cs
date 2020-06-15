using ShoppingCar.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Infraestructure
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Task<Category> GetCategoryByIdAsync(int? id);
        Task InsertCategoryAsync (Category category);
        Task UpdateCategoryAsync(Category category);
        Task DeleteCategoryAsyn(int? id);
    }
}
