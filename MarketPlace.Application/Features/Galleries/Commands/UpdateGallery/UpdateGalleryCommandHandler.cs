using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Exceptions;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Galleries.Commands.UpdateGallery
{
    public class UpdateGalleryCommandHandler : IRequestHandler<UpdateGalleryCommand>
    {
        private readonly IAsyncRepository<Gallery> _galleryRepository;
        private readonly IMapper _mapper;

        public UpdateGalleryCommandHandler(IMapper mapper, IAsyncRepository<Gallery> galleryRepository)
        {
            _mapper = mapper;
            _galleryRepository = galleryRepository;
        }

        public async Task<Unit> Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {

            var glleryToUpdate = await _galleryRepository.GetByIdAsync(request.GalleryId);

            if (glleryToUpdate == null)
            {
                throw new NotFoundException(nameof(Gallery), request.GalleryId);
            }

            var validator = new UpdateGalleryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, glleryToUpdate, typeof(UpdateGalleryCommand), typeof(Gallery));

            await _galleryRepository.UpdateAsync(glleryToUpdate);

            return Unit.Value;
        }
    }
}