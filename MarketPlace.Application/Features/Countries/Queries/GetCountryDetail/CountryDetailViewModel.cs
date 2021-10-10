using MarketPlace.Application.DTOs;
using System;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountryDetail
{
    public class CountryDetailViewModel
    {
        public Guid CountryId { get; set; }
        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public string ShortName { get; set; }

        public CurrencyDTO? Currency { get; set; }
        public Guid? CurrencyId { get; set; }

        public LanguageDTO? Language { get; set; }
        public Guid? LanguageId { get; set; }

        public DateTime Date { get; set; }
    }
}
