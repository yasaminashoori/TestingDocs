using Microsoft.EntityFrameworkCore;
using ProductShop.Domain;

namespace ProductShop.Repository
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> option) : base(option)
        {
           
        }
    }
}
