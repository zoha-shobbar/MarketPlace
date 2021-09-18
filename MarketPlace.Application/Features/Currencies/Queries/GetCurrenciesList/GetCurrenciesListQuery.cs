using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrenciesList

{
    public class GetCurrenciesListQuery : IRequest<List<CurrenciesListViewModel>>
    {

    }
}
