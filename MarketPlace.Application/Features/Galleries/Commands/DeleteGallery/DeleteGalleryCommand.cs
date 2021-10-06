using MediatR;
using System;

namespace MarketPlace.Application.Features.Galleries.Commands.DeleteGallery
{
    public class DeleteGalleryCommand : IRequest
    {
        public Guid GalleryId { get; set; }
    }
}
