using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyDetail

{
    public class GetCurrencyDetailEventHandler : IRequestHandler<GetMenuDetailQuery, CurrencyDetailViewModel>
    {
        private readonly IAsyncRepository<Country> _countryRepository;
        private IMapper _mapper;
        public GetCurrencyDetailEventHandler(IMapper mapper, IAsyncRepository<Country> countryRepository, IAsyncRepository<Language> languageRepository, IAsyncRepository<Currency> currencyRepository)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<CurrencyDetailViewModel> Handle(GetMenuDetailQuery request, CancellationToken cancellationToken)
        {
            var @currency = await _countryRepository.GetByIdAsync(request.Id);
            var currencyDetailDTO = _mapper.Map<CurrencyDetailViewModel>(currency);

            return currencyDetailDTO;
        }
    }
}
