using MediatR;
using System;

namespace MarketPlace.Application.Features.Products.Commands.CreateProducts
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string ShortName { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string SerialNum { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? SpecialSellPrice { get; set; }

        public bool CellarManagment { get; set; }

        public string Inventory { get; set; }

        public decimal? LowInventoryThreshold { get; set; }

        public double? Weight { get; set; }

        public string? Dimensions { get; set; }

        public string? CrossSells { get; set; }

        public bool ForMoreSell { get; set; }

        public byte PublishStatus { get; set; }

        public bool AllowComment { get; set; }

        public Guid? CurrencyId { get; set; }

        public Guid? ManufacturingCountryId { get; set; }

        public Guid? ProductCategoryId { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
