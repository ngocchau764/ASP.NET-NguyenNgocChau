using Microsoft.EntityFrameworkCore;
using NguyenThiNgocChau_2122110055.Model;

namespace NguyenThiNgocChau_2122110055.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
   
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<OrderItem> OrderItems { get; set; }
        
        public DbSet<Order> Orders { get; set; }

    }
}
