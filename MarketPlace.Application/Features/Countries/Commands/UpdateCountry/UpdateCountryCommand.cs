using MediatR;
using System;

namespace MarketPlace.Application.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommand : IRequest
    {
        public Guid CountryId { get; set; }
        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public string ShortName { get; set; }

        public Guid? CurrencyId { get; set; }

        public Guid? LanguageId { get; set; }
    }
}
