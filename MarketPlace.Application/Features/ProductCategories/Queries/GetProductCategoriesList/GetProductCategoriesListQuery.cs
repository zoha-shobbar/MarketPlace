using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoriesList
{
    public class GetProductCategoriesListQuery : IRequest<List<ProductCategoryListViewModel>>
    {

    }
}
