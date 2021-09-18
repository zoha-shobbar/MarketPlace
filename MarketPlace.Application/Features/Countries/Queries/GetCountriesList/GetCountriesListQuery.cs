using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountriesList
{
    public class GetCountriesListQuery : IRequest<List<CountryListViewModel>>
    {

    }
}
