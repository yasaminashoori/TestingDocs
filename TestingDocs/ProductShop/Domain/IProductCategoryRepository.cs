namespace ProductShop.Domain
{
    public interface IProductCategoryRepository
    {
        ProductCategory FindById(int id);   
    }
}
