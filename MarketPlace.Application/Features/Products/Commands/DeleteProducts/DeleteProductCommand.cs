using MediatR;
using System;

namespace MarketPlace.Application.Features.Products.Commands.DeleteProducts
{
    public class DeleteProductCommand : IRequest
    {
        public Guid ProductId { get; set; }
    }
}
