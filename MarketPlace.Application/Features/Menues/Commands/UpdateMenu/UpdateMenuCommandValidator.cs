using FluentValidation;
using MarketPlace.Application.Contracts.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Commands.UpdateMenu
{
    public class UpdateMenuCommandValidator : AbstractValidator<UpdateMenuCommand>
    {
        private readonly IMenuRepository _menuRepository;
        public UpdateMenuCommandValidator()
        {
            RuleFor(p => p.Sort)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(e => e)
                .MustAsync(IsParentMenuIdItsId).WithMessage("{PropertyName} must not be its own Id.");

            RuleFor(p => p.MenueTitle)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.MenuType)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .GreaterThan(-1).WithMessage("{PropertyName} must select one menu type.");

            RuleFor(p => p.PageAndPostId)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull();
        }


        private async Task<bool> IsParentMenuIdItsId(UpdateMenuCommand updateProducCommand, CancellationToken cancellationToken)
        {
            return !(await _menuRepository.IsParentMenuIdItsId(updateProducCommand.MenuId, (Guid)updateProducCommand.ParentMenuId));
        }
    }
}
