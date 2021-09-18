using System;

namespace MarketPlace.Application.DTOs
{
    public class CurrencyDTO
    {
        public Guid Id { get; set; }
       
        public string Title { get; set; }

        public string Symbol { get; set; }
    }
}
