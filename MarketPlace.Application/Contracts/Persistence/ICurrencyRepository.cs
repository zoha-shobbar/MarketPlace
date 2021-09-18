using MarketPlace.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface ICurrencyRepository : IAsyncRepository<Currency>
    {
        Task<List<Currency>> GetCurrencyListWithCountries();
    }
}
