using MarketPlace.Domain.Entities;
using System.Threading.Tasks;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<bool> IsSpecialPriceLessThanMainPrice(decimal mainPrice, decimal specialPrice);
        Task<bool> IsSpecialPriceLessThanMainPrice(string serialNum);
    }
}
