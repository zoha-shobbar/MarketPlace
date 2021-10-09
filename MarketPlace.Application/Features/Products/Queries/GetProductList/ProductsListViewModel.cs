using System;

namespace MarketPlace.Application.Features.Products.Queries.GetProductList
{
    public class ProductsListViewModel
    {
        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string ShortName { get; set; }
        
        public string URL { get; set; }

        public decimal? Price { get; set; }

        public int? Quantity { get; set; }

        public string SerialNum { get; set; }

        public decimal? PurchasePrice { get; set; }

        public decimal? SpecialSellPrice { get; set; }
    }
}
