using MediatR;
using System;

namespace MarketPlace.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCountryCommand : IRequest<Guid>
    {
        public Guid CountryId { get; set; }
        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public string ShortName { get; set; }

        public Guid? CurrencyId { get; set; }

        public Guid? LanguageId { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
