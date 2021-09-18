

using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuList

{
    public class GetMenuListQueryHandler : IRequestHandler<GetMenuListQuery, List<MenuListViewModel>>
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMapper _mapper;

        public GetMenuListQueryHandler(IMapper mapper, IMenuRepository menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public async Task<List<MenuListViewModel>> Handle(GetMenuListQuery request, CancellationToken cancellationToken)
        {
            var allMenues = (await _menuRepository.ListAllAsync()).OrderBy(x => x.MenuType).OrderBy(x => x.Sort);
            return _mapper.Map<List<MenuListViewModel>>(allMenues);
        }

    }

}
