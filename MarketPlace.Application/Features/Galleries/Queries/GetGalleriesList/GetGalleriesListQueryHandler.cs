using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleriesList
{
    public class GetGalleriesListQueryHandler : IRequestHandler<GetGalleriesListQuery, List<GalleryListViewModel>>
    {
        private readonly IAsyncRepository<Gallery> _galleyRepository;
        private readonly IMapper _mapper;

        public GetGalleriesListQueryHandler(IMapper mapper, IAsyncRepository<Gallery> galleryRepository)
        {
            _mapper = mapper;
            _galleyRepository = galleryRepository;
        }

        public async Task<List<GalleryListViewModel>> Handle(GetGalleriesListQuery request, CancellationToken cancellationToken)
        {
            var allGalleries = (await _galleyRepository.ListAllAsync()).OrderBy(x => x.CreatedDate).OrderBy(x => x.Title);
            return _mapper.Map<List<GalleryListViewModel>>(allGalleries);
        }
    }
}
