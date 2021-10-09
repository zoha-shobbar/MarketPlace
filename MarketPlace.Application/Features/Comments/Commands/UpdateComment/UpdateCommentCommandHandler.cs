using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Commands.UpdateComment
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IAsyncRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;

        public UpdateCommentCommandHandler(IMapper mapper, IAsyncRepository<Comment> commentRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }

        public async Task<Unit> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {

            var commentToUpdate = await _commentRepository.GetByIdAsync(request.CommentId);

            if (commentToUpdate == null)
            {
                throw new NotFoundException(nameof(Comment), request.CommentId);
            }

            var validator = new UpdateCommentCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, commentToUpdate, typeof(UpdateCommentCommand), typeof(Comment));

            await _commentRepository.UpdateAsync(commentToUpdate);

            return Unit.Value;
        }
    }
}