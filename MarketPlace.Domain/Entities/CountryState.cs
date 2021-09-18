using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class CountryState : AuditableEntity
    {
        public Guid CountryStateId { get; set; }

        public string Title { get; set; }

        public Country Country { get; set; }
        public Guid CountryId { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
