using ShoppingCar.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Infraestructure
{
    public interface IProduct
    {
        IEnumerable<Category> GetAllProducts();
        Task<Category> GetProductByIdAsync(int id);
        Task InsertProduct(Category product);
        Task UpdateProductAsync(Category product);
        Task DeleteProductAsync(Category product);
    }
}
