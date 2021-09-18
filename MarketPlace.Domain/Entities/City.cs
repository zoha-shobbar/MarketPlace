using MarketPlace.Domain.Common;
using System;

namespace MarketPlace.Domain.Entities
{
    public class City : AuditableEntity
    {
        public Guid CityId { get; set; }

        public string Title { get; set; }

        public CountryState CountryState { get; set; }
        public Guid CountryStateId { get; set; }
    }
}
