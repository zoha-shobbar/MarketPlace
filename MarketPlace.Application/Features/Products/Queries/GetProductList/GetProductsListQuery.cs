using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Products.Queries.GetProductList
{
    public class GetProductsListQuery: IRequest<List<ProductsListViewModel>>
    {

    }
}
