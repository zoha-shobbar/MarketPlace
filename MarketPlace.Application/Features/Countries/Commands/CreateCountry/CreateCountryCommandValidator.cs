using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Features.Countries.Commands.UpdateCountry;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCountryCommandValidator : AbstractValidator<CreateCountryCommand>
    {

        private readonly ICountryRepository _countryRepository;
        public CreateCountryCommandValidator()
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

        private async Task<bool> IsCurrencyIdEmpty(CreateCountryCommand createProducCommand, CancellationToken cancellationToken)
        {
            return !await _countryRepository.IsGuidEmpty((Guid)createProducCommand.CurrencyId);
        }
        private async Task<bool> IsLanguageIdEmpty(CreateCountryCommand createProducCommand, CancellationToken cancellationToken)
        {
            return !await _countryRepository.IsGuidEmpty((Guid)createProducCommand.LanguageId);
        }
    }
}
