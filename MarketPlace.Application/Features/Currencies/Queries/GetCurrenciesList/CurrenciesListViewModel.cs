using System;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrenciesList
{
    public class CurrenciesListViewModel
    {
        public Guid CountryId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }
}
