using Microsoft.EntityFrameworkCore;
using ShopTest1.Models;

namespace ShopTest1.Repository
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                .HasKey(m => new { m.ProductID});

                
        }
    }
}
