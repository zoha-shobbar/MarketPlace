using MarketPlace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface ICommentRepository : IAsyncRepository<Comment>
    {
        Task<IReadOnlyList<Comment>> GetByProductIdAsync(Guid id);
        Task<IReadOnlyList<Comment>> GetByPageIdAsync(Guid id);

    }
}
