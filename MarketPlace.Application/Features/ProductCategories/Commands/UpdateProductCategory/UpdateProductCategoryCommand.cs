using MediatR;
using System;

namespace MarketPlace.Application.Features.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommand : IRequest
    {
        public Guid ProductCategoryId { get; set; }

        public string Title { get; set; }

        public string ShorTitle { get; set; }

        public string Description { get; set; }
    }
}
