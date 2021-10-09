using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostList
{
    public class GetPageAndPostsListQueryHandler : IRequestHandler<PageAndPostsListQuery, List<PageAndPostListViewModel>>
    {
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IMapper _mapper;

        public GetPageAndPostsListQueryHandler(IMapper mapper, IAsyncRepository<PageAndPost> pageAndPostRepository)
        {
            _mapper = mapper;
            _pageAndPostRepository = pageAndPostRepository;
        }

        public async Task<List<PageAndPostListViewModel>> Handle(PageAndPostsListQuery request, CancellationToken cancellationToken)
        {
            var allPageAndPosts = (await _pageAndPostRepository.ListAllAsync()).OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<PageAndPostListViewModel>>(allPageAndPosts);
        }
    }
}
