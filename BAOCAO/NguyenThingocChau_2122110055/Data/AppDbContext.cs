using Microsoft.EntityFrameworkCore;
using NguyenThingocChau_2122110055.Model;

namespace NguyenThingocChau_2122110055.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }  // Thêm dòng này

    }
}
