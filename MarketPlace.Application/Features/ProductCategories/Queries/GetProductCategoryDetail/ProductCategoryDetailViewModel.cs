using System;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoryDetail
{
    public class ProductCategoryDetailViewModel
    {
        public Guid ProductCategoryId { get; set; }
        
        public string Title { get; set; }

        public string ShorTitle { get; set; }

        public string Description { get; set; }
    }
}
