using ShoppingCar.Data.Model;
using ShoppingCar.Service.Infraestructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Repository
{
    public class ProductRepository : IProduct
    {
        public Task DeletePruduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> InsertProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task Save()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
