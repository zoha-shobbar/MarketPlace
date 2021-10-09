using MediatR;
using System;

namespace MarketPlace.Application.Features.Currencies.Queries.GetCurrencyDetail
{
    public class GetCurrencyDetailQuery : IRequest<CurrencyDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
