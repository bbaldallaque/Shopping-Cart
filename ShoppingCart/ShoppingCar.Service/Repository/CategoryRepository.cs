using ShoppingCar.Data.Model;
using ShoppingCar.Service.DataContext;
using ShoppingCar.Service.Infraestructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCar.Service.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteCategoryAsyn(int? id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public async Task<Category> GetCategoryByIdAsync(int? id)
        {
            return await _context.Categories.FindAsync(id);
        }
    
        public async Task InsertCategoryAsync(Category category)
        {
            _context.Products.Update(category);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
