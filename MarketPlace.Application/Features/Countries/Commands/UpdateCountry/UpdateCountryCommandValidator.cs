using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Features.Products.Commands.UpdateProducts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandValidator : AbstractValidator<UpdateCountryCommand>
    {

        private readonly ICountryRepository _countryRepository;
        public UpdateCountryCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

            RuleFor(p => p.TitleWithOrginalLanguage)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} must not exceed 150 characters.");

            RuleFor(p => p.ShortName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.CurrencyId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(e => e)
                .MustAsync(IsCurrencyIdEmpty).WithMessage("{PropertyName}  is required.");

            RuleFor(p => p.ShortName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.LanguageId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(e => e)
                .MustAsync(IsLanguageIdEmpty).WithMessage("{PropertyName}  is required.");
        }

        private async Task<bool> IsCurrencyIdEmpty(UpdateCountryCommand updateProducCommand, CancellationToken cancellationToken)
        {
            return !await _countryRepository.IsGuidEmpty((Guid)updateProducCommand.CurrencyId);
        }
        private async Task<bool> IsLanguageIdEmpty(UpdateCountryCommand updateProducCommand, CancellationToken cancellationToken)
        {
            return !await _countryRepository.IsGuidEmpty((Guid)updateProducCommand.LanguageId);
        }
    }
}
