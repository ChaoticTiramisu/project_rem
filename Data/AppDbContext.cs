using Microsoft.EntityFrameworkCore;
using project_rem.Models;  // Make sure to import the Models namespace

namespace project_rem.Data  // Adjust based on your folder structure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }  // Add your Product model here

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
