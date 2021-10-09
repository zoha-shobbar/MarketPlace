using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuDetail

{
    public class GetMenuDetailMenuHandler : IRequestHandler<GetMenuDetailQuery, MenuDetailViewModel>
    {
        private readonly IAsyncRepository<Menu> _menuRepository;
        private IMapper _mapper;
        public GetMenuDetailMenuHandler(IMapper mapper, IAsyncRepository<Menu> menuRepository)
        {
            _menuRepository = menuRepository;
            _mapper = mapper;
        }

        public async Task<MenuDetailViewModel> Handle(GetMenuDetailQuery request, CancellationToken cancellationToken)
        {
            var menu = await _menuRepository.GetByIdAsync(request.Id);
            var currencyDetailDTO = _mapper.Map<MenuDetailViewModel>(menu);

            return currencyDetailDTO;
        }
    }
}
