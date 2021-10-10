using MarketPlace.Application.DTOs;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyListWithCountries
{
    public class CurrencyCountryListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CurrencyCountryDTO> Countries { get; set; }
    }
}
