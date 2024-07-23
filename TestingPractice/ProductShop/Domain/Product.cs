namespace ProductShop.Domain
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; }        
        public string Description { get; set; } 
        public int ProductCategoryId { get; set; }  
        public ProductCategory ProductCategory { get; set;}
        public Product()
        {
            
        }
    }
}
