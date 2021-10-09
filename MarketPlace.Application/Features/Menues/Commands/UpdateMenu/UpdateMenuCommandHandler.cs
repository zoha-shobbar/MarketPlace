using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Exceptions;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Commands.UpdateMenu
{
    public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommand>
    {
        private readonly IAsyncRepository<Menu> _menuRepository;
        private readonly IMapper _mapper;

        public UpdateMenuCommandHandler(IMapper mapper, IAsyncRepository<Menu> menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public async Task<Unit> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {

            var menuToUpdate = await _menuRepository.GetByIdAsync(request.MenuId);

            if (menuToUpdate == null)
            {
                throw new NotFoundException(nameof(Menu), request.MenuId);
            }

            var validator = new UpdateMenuCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, menuToUpdate, typeof(UpdateMenuCommand), typeof(Menu));

            await _menuRepository.UpdateAsync(menuToUpdate);

            return Unit.Value;
        }
    }
}