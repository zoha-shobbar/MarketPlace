using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountryDetail
{
    public class GetCountryDetailQueryHandler : IRequestHandler<GetCountryDetailQuery, CountryDetailViewModel>
    {
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IAsyncRepository<Currency> _currencyRepository;
        private readonly IAsyncRepository<Language> _languageRepository;
        private readonly IMapper _mapper;

        public GetCountryDetailQueryHandler(IMapper mapper, IAsyncRepository<Country> countryRepository, 
                                                            IAsyncRepository<Currency> currencyRepository,
                                                            IAsyncRepository<Language> languageRepository )
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
            _currencyRepository = currencyRepository;
        }

        public async Task<CountryDetailViewModel> Handle(GetCountryDetailQuery request, CancellationToken cancellationToken)
        {
            var @country = await _countryRepository.GetByIdAsync(request.Id);
            var countryDetailDto = _mapper.Map<CountryDetailViewModel>(@country);

            var currency= await _currencyRepository.GetByIdAsync((Guid)@country.CurrencyId);
            var language= await _languageRepository.GetByIdAsync((Guid)@country.LanguageId);

            countryDetailDto.Currency= _mapper.Map<CurrencyDTO>(currency);
            countryDetailDto.Language= _mapper.Map<LanguageDTO>(language);

            return countryDetailDto;
        }
    }
}
