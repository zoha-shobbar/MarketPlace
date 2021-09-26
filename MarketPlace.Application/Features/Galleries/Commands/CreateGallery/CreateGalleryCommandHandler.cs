using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Galleries.Commands.CreateGallery
{
    public class CreateGalleryCommandHandler : IRequestHandler<CreateGalleryCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IGalleryRepository _galleryRepository;

        public CreateGalleryCommandHandler(IMapper mapper, IGalleryRepository galleryRepository)
        {
            _mapper = mapper;
            _galleryRepository = galleryRepository;
        }

        public async Task<Guid> Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
        {
            var gallery = _mapper.Map<Gallery>(request);
            gallery = await _galleryRepository.AddAsync(gallery);
            return gallery.GalleryId;
        }
    }
}
