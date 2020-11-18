using Microsoft.EntityFrameworkCore;

namespace KMShop.Models
{
    public class CarDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public CarDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionstring =
@"Server=DESKTOP-RJ9ED1F\\SQLEXPRESS;Database=carstoredb;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(connectionstring,
                options => options.EnableRetryOnFailure());

            }
        }
    }
}
