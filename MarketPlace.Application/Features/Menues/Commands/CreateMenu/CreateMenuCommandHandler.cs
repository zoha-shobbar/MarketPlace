using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IMenuRepository _menuRepository;

        public CreateMenuCommandHandler(IMapper mapper, IMenuRepository menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public async Task<Guid> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = _mapper.Map<Menu>(request);
            menu = await _menuRepository.AddAsync(menu);
            return menu.MenuId;
        }
    }
}
