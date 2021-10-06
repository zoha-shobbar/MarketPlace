using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent;
using MarketPlace.Application.Features.Menues.Commands.DeleteMenu;
using MarketPlace.Application.Features.PageAndPosts.Commands.DeletePageAndPost;
using MarketPlace.Application.Features.ProductCategories.Commands.DeleteProductCategory;
using MarketPlace.Application.Features.Products.Commands.DeleteProducts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.DeleteLanguage
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Event), request.EventId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
