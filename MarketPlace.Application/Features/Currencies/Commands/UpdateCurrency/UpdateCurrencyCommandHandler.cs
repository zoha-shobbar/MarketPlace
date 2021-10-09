using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Currencies.Commands.UpdateCurrency
{
    public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand>
    {
        private readonly IAsyncRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;

        public UpdateCurrencyCommandHandler(IMapper mapper, IAsyncRepository<Currency> currencyRepository)
        {
            _mapper = mapper;
            _currencyRepository = currencyRepository;
        }

        public async Task<Unit> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
        {

            var currencyToUpdate = await _currencyRepository.GetByIdAsync(request.CurrencyId);

            if (currencyToUpdate == null)
            {
                throw new NotFoundException(nameof(Currency), request.CurrencyId);
            }

            var validator = new UpdateCurrencyCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, currencyToUpdate, typeof(UpdateCurrencyCommand), typeof(Currency));

            await _currencyRepository.UpdateAsync(currencyToUpdate);

            return Unit.Value;
        }
    }
}