using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task GetByIdAsync(object currency);
        Task<bool> IsGuidEmpty(Guid guid);

    }
}
