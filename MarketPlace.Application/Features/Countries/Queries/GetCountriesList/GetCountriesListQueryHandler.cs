using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountriesList
{
    public class GetCountriesListQueryHandler : IRequestHandler<GetCountriesListQuery, List<CountryListViewModel>>
    {
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IMapper _mapper;

        public GetCountriesListQueryHandler(IMapper mapper, IAsyncRepository<Country> CountryRepository)
        {
            _mapper = mapper;
            _countryRepository = CountryRepository;
        }

        public async Task<List<CountryListViewModel>> Handle(GetCountriesListQuery request, CancellationToken cancellationToken)
        {
            var allCountries = (await _countryRepository.ListAllAsync()).OrderBy(x => x.Title);
            return _mapper.Map<List<CountryListViewModel>>(allCountries);
        }

    }

}
