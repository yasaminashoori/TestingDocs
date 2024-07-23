using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductShop.Domain;
using ProductShop.Domain.DTO;
using ProductShop.Repository;
using ProductShop.Validation;

namespace ProductShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _productcategoryRepository;        

        public ProductController(IProductRepository productRepository, IProductCategoryRepository productcategoryRepository)
        {
            _productRepository = productRepository;
            _productcategoryRepository = productcategoryRepository; 

        }

        [HttpPost]
        public IActionResult CreateProduct(ProductDTO productdto) 
        {
            var validation = new ProductValidator(_productcategoryRepository);
            var result = validation.Validate(productdto); 
            if (!result.IsValid) 
            {
                throw new Exception("خطا");
            } 
            return Ok();
        }
    }
}
