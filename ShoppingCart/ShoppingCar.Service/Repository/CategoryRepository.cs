using Microsoft.EntityFrameworkCore;
using ShoppingCar.Data.Model;
using ShoppingCar.Service.DataContext;
using ShoppingCar.Service.Infraestructure;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCar.Service.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void  DeleteCategory (Category category)
        {
            _context.Categories.Remove(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            return _context.Categories.Where(x => x.Id==Id).FirstOrDefault();
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
