using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyListWithCountries
{
    public class GetCurrencyListWithCountriesQuery : IRequest<List<CurrencyCountryListViewModel>>
    {
    }
}
