using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KMShop.Models
{
    public class UserDbContext : IdentityDbContext
    {
        //public DbSet<User> Users { get; set; }
        public UserDbContext(DbContextOptions<UserDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
