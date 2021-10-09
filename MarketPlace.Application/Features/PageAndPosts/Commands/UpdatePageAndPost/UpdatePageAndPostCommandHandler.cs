using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.PageAndPosts.Commands.UpdatePageAndPost
{
    public class UpdatePageAndPostCommandHandler : IRequestHandler<UpdatePageAndPostCommand>
    {
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IMapper _mapper;

        public UpdatePageAndPostCommandHandler(IMapper mapper, IAsyncRepository<PageAndPost> pageAndPostRepository)
        {
            _mapper = mapper;
            _pageAndPostRepository = pageAndPostRepository;
        }

        public async Task<Unit> Handle(UpdatePageAndPostCommand request, CancellationToken cancellationToken)
        {

            var pageAndPostToUpdate = await _pageAndPostRepository.GetByIdAsync(request.PageAndPostId);

            if (pageAndPostToUpdate == null)
            {
                throw new NotFoundException(nameof(PageAndPost), request.PageAndPostId);
            }

            var validator = new UpdatePageAndPostCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, pageAndPostToUpdate, typeof(UpdatePageAndPostCommand), typeof(PageAndPost));

            await _pageAndPostRepository.UpdateAsync(pageAndPostToUpdate);

            return Unit.Value;
        }
    }
}