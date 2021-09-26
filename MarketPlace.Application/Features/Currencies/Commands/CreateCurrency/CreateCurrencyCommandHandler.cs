using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICurrencyRepository _currencyRepository;

        public CreateCurrencyCommandHandler(IMapper mapper, ICurrencyRepository currencyRepository)
        {
            _mapper = mapper;
            _currencyRepository = currencyRepository;
        }

        public async Task<Guid> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = _mapper.Map<Currency>(request);
            currency = await _currencyRepository.AddAsync(currency);
            return currency.CurrencyId;
        }
    }
}
