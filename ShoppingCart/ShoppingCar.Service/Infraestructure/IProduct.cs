using ShoppingCar.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Infraestructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> InsertProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeletePruduct(Product product);
        Task Save();
    }
}
