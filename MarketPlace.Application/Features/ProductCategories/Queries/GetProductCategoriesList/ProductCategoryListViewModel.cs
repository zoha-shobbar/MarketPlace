using System;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoriesList
{
    public class ProductCategoryListViewModel
    {
        public Guid ProductCategoryId { get; set; }
       
        public string Title { get; set; }

        public string ShorTitle { get; set; }

        public string Description { get; set; }
    }
}
