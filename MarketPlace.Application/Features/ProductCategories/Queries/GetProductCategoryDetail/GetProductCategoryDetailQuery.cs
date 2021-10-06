using MediatR;
using System;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoryDetail
{
    public class GetProductCategoryDetailQuery : IRequest<ProductCategoryDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
