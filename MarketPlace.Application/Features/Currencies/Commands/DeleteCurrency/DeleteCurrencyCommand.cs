using MediatR;
using System;

namespace MarketPlace.Application.Features.Currencies.Commands.DeleteCurrency
{
    public class DeleteCurrencyCommand : IRequest
    {
        public Guid CurrencyId { get; set; }
    }
}
