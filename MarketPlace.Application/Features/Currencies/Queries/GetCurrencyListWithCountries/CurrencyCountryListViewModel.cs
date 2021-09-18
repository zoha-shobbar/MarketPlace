using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyListWithCountries
{
    public class CurrencyCountryListViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CurrencyCountryDTO> Countries { get; set; }
    }
}
