using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Country : AuditableEntity
    {
        public Guid CountryId{ get; set; }
        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public string ShortName { get; set; }

        public Currency? Currency { get; set; }
        public Guid? CurrencyId { get; set; }

        public Language? Language { get; set; }
        public Guid? LanguageId { get; set; }

        public ICollection<CountryState> CountryStates { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
