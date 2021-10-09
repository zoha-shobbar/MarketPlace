using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.PageAndPosts.Commands.DeletePageAndPost
{
    public class DeletePageAndPostCommandHandler : IRequestHandler<DeletePageAndPostCommand>
    {
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IMapper _mapper;

        public DeletePageAndPostCommandHandler(IMapper mapper, IAsyncRepository<PageAndPost> pageAndPostRepository)
        {
            _mapper = mapper;
            _pageAndPostRepository = pageAndPostRepository;
        }

        public async Task<Unit> Handle(DeletePageAndPostCommand request, CancellationToken cancellationToken)
        {
            var pageAndPostToDelete = await _pageAndPostRepository.GetByIdAsync(request.PageAndPostId);

            if (pageAndPostToDelete == null)
            {
                throw new NotFoundException(nameof(PageAndPost), request.PageAndPostId);
            }

            await _pageAndPostRepository.DeleteAsync(pageAndPostToDelete);

            return Unit.Value;
        }
    }
}
