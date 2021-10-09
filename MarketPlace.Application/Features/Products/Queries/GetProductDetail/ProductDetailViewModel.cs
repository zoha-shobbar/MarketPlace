using MarketPlace.Application.DTOs;
using System;

namespace MarketPlace.Application.Features.Products.Queries.GetProductDetail
{
    public class ProductDetailViewModel
    {
        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string ShortName { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

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

        public byte? PublishStatus { get; set; }

        public bool AllowComment { get; set; }

        public CurrencyDTO Currency { get; set; }
        public Guid? CurrencyId { get; set; }

        public CountryDTO ManufacturingCountry { get; set; }
        public Guid? ManufacturingCountryId { get; set; }

        public ProductCategoryDTO ProductCategory { get; set; }
        public Guid? ProductCategoryId { get; set; }
    }
}
