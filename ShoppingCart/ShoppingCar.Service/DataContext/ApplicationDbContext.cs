using Microsoft.EntityFrameworkCore;
using ShoppingCar.Data.Model;

namespace ShoppingCar.Service.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
