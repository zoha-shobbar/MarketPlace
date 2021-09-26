using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.PageAndPosts.Commands.CreatePageAndPost
{
    public class CreatePageAndPostCommandHandler : IRequestHandler<CreatePageAndPostCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IPageAndPostRepository _pageAndPostRepository;

        public CreatePageAndPostCommandHandler(IMapper mapper, IPageAndPostRepository pageAndPostRepository)
        {
            _mapper = mapper;
            _pageAndPostRepository = pageAndPostRepository;
        }

        public async Task<Guid> Handle(CreatePageAndPostCommand request, CancellationToken cancellationToken)
        {
            var pageAndPost = _mapper.Map<PageAndPost>(request);
            pageAndPost = await _pageAndPostRepository.AddAsync(pageAndPost);
            return pageAndPost.PageAndPostId;
        }
    }
}
