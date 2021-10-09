using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Commands.UpdateComment
{
    public class UpdateCommentCommandValidator : AbstractValidator<UpdateCommentCommand>
    {

        private readonly ICommentRepository _commentRepository;
        public UpdateCommentCommandValidator()
        {
            RuleFor(p => p.Message)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.WriterName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.WriterEmail)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(150).WithMessage("{PropertyName} must not exceed 150 characters.");
           
        }

    }
}
