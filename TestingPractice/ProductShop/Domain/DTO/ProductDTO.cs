namespace ProductShop.Domain.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }     

        public int ProductCategoryId { get; set; }  
    }
}
