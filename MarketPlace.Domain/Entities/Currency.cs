using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Currency : AuditableEntity
    {
        public Guid CurrencyId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public ICollection<Country> Countries { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
