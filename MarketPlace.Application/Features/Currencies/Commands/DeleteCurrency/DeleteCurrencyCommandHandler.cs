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
        private readonly IAsyncRepository<Currency> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteCurrencyCommandHandler(IMapper mapper, IAsyncRepository<Currency> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.CurrencyId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Currency), request.CurrencyId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
