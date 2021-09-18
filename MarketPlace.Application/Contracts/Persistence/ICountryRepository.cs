﻿using MarketPlace.Domain.Entities;

namespace MarketPlace.Application.Contracts.Persistence
{
    public interface ICountryRepository : IAsyncRepository<Country>
    {
    }
}
