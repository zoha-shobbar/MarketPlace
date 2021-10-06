using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Commands.DeleteMenu
{
    public class DeleteMenuCommandHandler : IRequestHandler<DeleteMenuCommand>
    {
        private readonly IAsyncRepository<Menu> _menuRepository;
        private readonly IMapper _mapper;

        public DeleteMenuCommandHandler(IMapper mapper, IAsyncRepository<Menu> menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public async Task<Unit> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            var menuToDelete = await _menuRepository.GetByIdAsync(request.MenuId);

            if (menuToDelete == null)
            {
                throw new NotFoundException(nameof(Menu), request.MenuId);
            }

            await _menuRepository.DeleteAsync(menuToDelete);

            return Unit.Value;
        }
    }
}
