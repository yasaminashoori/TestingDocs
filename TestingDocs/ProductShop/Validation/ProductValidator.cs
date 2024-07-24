using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using ProductShop.Domain;
using ProductShop.Domain.DTO;
using static ProductShop.Validation.Constants;

namespace ProductShop.Validation
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        private readonly IProductCategoryRepository _categoryRepository;
        public ProductValidator(IProductCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(NameIsRequired).Length(3, 40); // could be shorter
            RuleFor(x => x.Name)
                .Length(3, 50)
                .WithMessage(NameLength);
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage(DescriptionIsRequired);
            RuleFor(x => x.Description)
                .Length(3, 20)
                .WithMessage(DescriptionLength);
            RuleFor(x => x.ProductCategoryId).Must(ValidateProductCAtegoryId).WithMessage(ProductCategoryNotFoundById);
        }


        public bool ValidateProductCAtegoryId(int id)
        {
            var productIsFound = _categoryRepository.FindById(id);
            if (productIsFound == null)
            {
                return false;
            }
            return true;
        }

        // Async Rule For
        //uleFor(x => x.ProductCategoryId).MustAsync(ValidateProductCAtegoryId).WithMessage(ProductCategoryNotFoundById);


        // Method For Async Validation
        //public Task<bool> ValidateProductCAtegoryId(int id, CancellationToken token)
        //{
        //    var productIsFound = _categoryRepository.FindById(id);
        //    if (productIsFound == null)
        //    {
        //        return Task.FromResult(true);
        //    }
        //    return Task.FromResult(false);
        //}
    }
}
   
