using MarketPlace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface IGalleryRepository : IAsyncRepository<Gallery>
    {
        Task<IReadOnlyList<Gallery>> GetByPageAndPostIdAsync(Guid id);
        Task<IReadOnlyList<Gallery>> GetByProductIdAsync(Guid id);

    }
}
