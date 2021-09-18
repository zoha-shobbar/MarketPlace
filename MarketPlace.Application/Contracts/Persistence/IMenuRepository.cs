using MarketPlace.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface IMenuRepository : IAsyncRepository<Menu>
    {
        Task<IReadOnlyList<Menu>> ListByTypeAsync(MenuType menuType);

    }
}
