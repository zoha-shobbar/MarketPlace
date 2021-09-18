using System;

namespace MarketPlace.Application.DTOs
{
    public class CurrencyCountryDTO
    {
        public Guid CountryId { get; set; }
        public string Title { get; set; }
        public Guid CurrencyId { get; set; }
    }
}
