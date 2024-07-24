using ProductShop.Domain;
using System.Linq;

namespace ProductShop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _context;

        public ProductRepository(ShopDbContext context)
        {
            _context = context; 
        }

        public void Create(Product product)
        {
           _context.Products.Add(product);  
        }

        public Product FindById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
