using MediatR;
using System;

namespace MarketPlace.Application.Features.ProductCategories.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommand : IRequest
    {
        public Guid ProductCategoryId { get; set; }
    }
}
