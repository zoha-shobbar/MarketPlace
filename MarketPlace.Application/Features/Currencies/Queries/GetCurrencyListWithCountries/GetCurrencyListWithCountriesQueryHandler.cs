using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyListWithCountries
{
    public class GetCurrencyListWithCountriesQueryHandler : IRequestHandler<GetCurrencyListWithCountriesQuery, List<CurrencyCountryListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyListWithCountriesQueryHandler(IMapper mapper, ICurrencyRepository currencyRepository)
        {
            _mapper = mapper;
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyCountryListViewModel>> Handle(GetCurrencyListWithCountriesQuery request, CancellationToken cancellationToken)
        {
            var list = await _currencyRepository.GetCurrencyListWithCountries();
            return _mapper.Map<List<CurrencyCountryListViewModel>>(list);
        }
    }
}
