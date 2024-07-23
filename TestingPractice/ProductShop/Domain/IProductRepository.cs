namespace ProductShop.Domain
{
    public interface IProductRepository
    {
        Product FindById(int id);

        void Create(Product product);
    }

}
