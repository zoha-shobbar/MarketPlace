using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Galleries.Commands.DeleteGallery
{
    public class DeleteGalleryCommandHandler : IRequestHandler<DeleteGalleryCommand>
    {
        private readonly IAsyncRepository<Gallery> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteGalleryCommandHandler(IMapper mapper, IAsyncRepository<Gallery> galleryRepository)
        {
            _mapper = mapper;
            _eventRepository = galleryRepository;
        }

        public async Task<Unit> Handle(DeleteGalleryCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.GalleryId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Gallery), request.GalleryId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
