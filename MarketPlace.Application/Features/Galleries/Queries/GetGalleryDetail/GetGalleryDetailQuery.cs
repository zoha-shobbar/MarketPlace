using MediatR;
using System;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleryDetail
{
    public class GetGalleryDetailQuery: IRequest<GalleryDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
