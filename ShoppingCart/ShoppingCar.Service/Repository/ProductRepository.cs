using ShoppingCar.Data.Model;
using ShoppingCar.Service.DataContext;
using ShoppingCar.Service.Infraestructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteProductAsync(Category product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Category> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public async Task<Category> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public  async Task InsertProduct(Category product)
        {
              _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
     
        public async Task UpdateProductAsync(Category product)
        {
             _context.Products.Update(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
