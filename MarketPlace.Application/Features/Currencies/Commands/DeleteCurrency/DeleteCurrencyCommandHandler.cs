using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Commands.DeleteCurrency
{
    public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand>
    {
        private readonly IAsyncRepository<Currency> _currencyyRepository;
        private readonly IMapper _mapper;

        public DeleteCurrencyCommandHandler(IMapper mapper, IAsyncRepository<Currency> currencyRepository)
        {
            _mapper = mapper;
            _currencyyRepository = currencyRepository;
        }

        public async Task<Unit> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currencyToDelete = await _currencyyRepository.GetByIdAsync(request.CurrencyId);

            if (currencyToDelete == null)
            {
                throw new NotFoundException(nameof(Currency), request.CurrencyId);
            }

            await _currencyyRepository.DeleteAsync(currencyToDelete);

            return Unit.Value;
        }
    }
}
