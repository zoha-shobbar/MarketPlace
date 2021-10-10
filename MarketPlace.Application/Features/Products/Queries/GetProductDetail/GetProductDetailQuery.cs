using MediatR;
using System;

namespace MarketPlace.Application.Features.Products.Queries.GetProductDetail
{
    public class GetProductDetailQuery : IRequest<ProductDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
