using MediatR;
using System;

namespace MarketPlace.Application.Features.Currencies.Commands.UpdateCurrency
{
    public class UpdateCurrencyCommand : IRequest
    {
        public Guid CurrencyId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
    }
}
