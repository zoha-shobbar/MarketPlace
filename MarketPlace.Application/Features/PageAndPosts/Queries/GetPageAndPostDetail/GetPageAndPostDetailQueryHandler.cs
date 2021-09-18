using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostDetail
{
    public class GetPageAndPostDetailQueryHandler : IRequestHandler<GetPageAndPostDetailQuery, PageAndPostDetailViewModel>
    {
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IGalleryRepository _galleryRepository;
        private readonly IMapper _mapper;

        public GetPageAndPostDetailQueryHandler(IMapper mapper, IPageAndPostRepository pageAndPostRepository,
                                                                IGalleryRepository galleryRepository)
        {
            _pageAndPostRepository = pageAndPostRepository;
            _galleryRepository = galleryRepository;
            _mapper = mapper;
        }

        public async Task<PageAndPostDetailViewModel> Handle(GetPageAndPostDetailQuery request, CancellationToken cancellationToken)
        {
            var @pageAndPost = await _pageAndPostRepository.GetByIdAsync(request.Id);
            var pageAndPostDetailDto = _mapper.Map<PageAndPostDetailViewModel>(@pageAndPost);

            var gallery = await _galleryRepository.GetByPageAndPostIdAsync(@pageAndPost.PageAndPostId);

            if (gallery == null)
            {
                //throw new NotFoundException(nameof(Event), request.Id);
            }
            pageAndPostDetailDto.Gallery = _mapper.Map<List<GalleryDTO>>(gallery);

            return pageAndPostDetailDto;
        }
    }
}
