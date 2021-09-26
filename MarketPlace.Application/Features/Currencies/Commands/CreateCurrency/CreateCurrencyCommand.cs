using MediatR;
using System;

namespace MarketPlace.Application.Features.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyCommand : IRequest<Guid>
    {
        public Guid CurrencyId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }
        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
