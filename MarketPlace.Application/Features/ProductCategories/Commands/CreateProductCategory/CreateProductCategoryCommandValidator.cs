using FluentValidation;
using MarketPlace.Application.Features.ProductCategories.Commands.UpdateProductCategory;

namespace MarketPlace.Application.Features.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommandValidator : AbstractValidator<CreateProductCategoryCommand>
    {
        public CreateProductCategoryCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.ShorTitle)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(20).WithMessage("{PropertyName} must not exceed 50 characters.")
                .NotNull();
        }
    }
}
