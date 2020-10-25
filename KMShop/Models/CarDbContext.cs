using Microsoft.EntityFrameworkCore;

namespace KMShop.Models
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
