using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;

namespace MarketPlace.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {

        private readonly ICommentRepository _commentRepository;
        public CreateCommentCommandValidator()
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

            RuleFor(p => p.UserId)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull();
        }

    }
}
