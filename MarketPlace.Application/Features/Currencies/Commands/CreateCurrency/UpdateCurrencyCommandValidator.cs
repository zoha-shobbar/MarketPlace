using FluentValidation;
using MarketPlace.Application.Features.Currencies.Commands.UpdateCurrency;

namespace MarketPlace.Application.Features.Currencies.Commands.CreateCurrency
{
    public class UpdateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
    {
        public UpdateCurrencyCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Symbol)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}
