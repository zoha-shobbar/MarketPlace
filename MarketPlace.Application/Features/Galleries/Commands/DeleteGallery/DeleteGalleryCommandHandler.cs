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
        private readonly IAsyncRepository<Gallery> _galleryRepository;
        private readonly IMapper _mapper;

        public DeleteGalleryCommandHandler(IMapper mapper, IAsyncRepository<Gallery> galleryRepository)
        {
            _mapper = mapper;
            _galleryRepository = galleryRepository;
        }

        public async Task<Unit> Handle(DeleteGalleryCommand request, CancellationToken cancellationToken)
        {
            var galleryToDelete = await _galleryRepository.GetByIdAsync(request.GalleryId);

            if (galleryToDelete == null)
            {
                throw new NotFoundException(nameof(Gallery), request.GalleryId);
            }

            await _galleryRepository.DeleteAsync(galleryToDelete);

            return Unit.Value;
        }
    }
}
