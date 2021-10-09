using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Commands.DeleteComment
{
    public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand>
    {
        private readonly IAsyncRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;

        public DeleteCommentCommandHandler(IMapper mapper, IAsyncRepository<Comment> commentRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }

        public async Task<Unit> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var commentToDelete = await _commentRepository.GetByIdAsync(request.CommentId);

            if (commentToDelete == null)
            {
                throw new NotFoundException(nameof(Comment), request.CommentId);
            }

            await _commentRepository.DeleteAsync(commentToDelete);

            return Unit.Value;
        }
    }
}
