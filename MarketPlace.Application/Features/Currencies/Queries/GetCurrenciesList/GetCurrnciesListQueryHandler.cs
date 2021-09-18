

using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrenciesList

{
    public class GetCurrnciesListQueryHandler : IRequestHandler<GetCurrenciesListQuery, List<CurrenciesListViewModel>>
    {
        private readonly IAsyncRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;

        public GetCurrnciesListQueryHandler(IMapper mapper, IAsyncRepository<Currency> currencyRepository)
        {
            _mapper = mapper;
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrenciesListViewModel>> Handle(GetCurrenciesListQuery request, CancellationToken cancellationToken)
        {
            var allCurrencies = (await _currencyRepository.ListAllAsync()).OrderBy(x => x.Title);
            return _mapper.Map<List<CurrenciesListViewModel>>(allCurrencies);
        }

    }

}
