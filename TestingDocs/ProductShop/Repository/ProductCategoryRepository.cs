using ProductShop.Domain;

namespace ProductShop.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ShopDbContext _context;

        public ProductCategoryRepository(ShopDbContext context)
        {
            _context = context; 
        }
        public ProductCategory FindById(int id)
        {
            return _context.ProductCategories.FirstOrDefault(x => x.Id == id);
        }
    }
}
