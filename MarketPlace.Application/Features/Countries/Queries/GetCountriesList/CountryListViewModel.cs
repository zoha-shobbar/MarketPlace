using System;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountriesList
{
    public class CountryListViewModel
    {
        public Guid CountryId { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public string? Currency { get; set; }

        public string? Language { get; set; }
    }
}
