using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Features.Products.Commands.UpdateProducts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Products.Commands.CreateProducts
{
    public class CreateProducCommandValidator : AbstractValidator<CreateProductCommand>
    {

        private readonly IProductRepository _productRepository;
        public CreateProducCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.");

            RuleFor(p => p.ShortName)
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 200 characters.")
                .NotNull();

            RuleFor(p => p.URL)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Description)
                 .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Quantity)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.SerialNum)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MinimumLength(2)
                .MaximumLength(25).WithMessage("{PropertyName} must not exceed 25 characters.")
                .NotNull();

            RuleFor(e => e)
                .MustAsync(IsSerialNumberUnique).WithMessage("{PropertyName} must not exceed 25 characters.")
                .NotNull();

            RuleFor(p => p.PurchasePrice)
                .GreaterThan(0).WithMessage("{PropertyName} must be grater than 25.")
                .NotNull();

            RuleFor(e => e)
                 .MustAsync(IsSpecialPriceLessThanMainPrice).WithMessage("{PropertyName} must be less than main price.")
                 .NotNull();

            RuleFor(p => p.CellarManagment)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Inventory)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.Dimensions)
                .MaximumLength(50).WithMessage("{PropertyName} is required.");

            RuleFor(p => p.PublishStatus)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull();

            RuleFor(p => p.AllowComment)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.CurrencyId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotEqual(Guid.Empty)
                .NotNull();

            RuleFor(p => p.ManufacturingCountryId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotEqual(Guid.Empty)
                .NotNull();

            RuleFor(p => p.ProductCategoryId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotEqual(Guid.Empty)
                .NotNull();
        }
        private async Task<bool> IsSpecialPriceLessThanMainPrice(CreateProductCommand updateProducCommand, CancellationToken cancellationToken)
        {
            return !await _productRepository.IsSpecialPriceLessThanMainPrice(updateProducCommand.Price, (decimal)updateProducCommand.SpecialSellPrice);
        }

        private async Task<bool> IsSerialNumberUnique(CreateProductCommand updateProducCommand, CancellationToken cancellationToken)
        {
            return !await _productRepository.IsSpecialPriceLessThanMainPrice(updateProducCommand.SerialNum);
        }
    }
}
