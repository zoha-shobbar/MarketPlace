using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoriesList
{
    public class GetProductCategoriesListQueryHandler : IRequestHandler<GetProductCategoriesListQuery, List<ProductCategoryListViewModel>>
    {
        private readonly IAsyncRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public GetProductCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<ProductCategory> productCategoryRepository)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<List<ProductCategoryListViewModel>> Handle(GetProductCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var allProductCategories = (await _productCategoryRepository.ListAllAsync()).OrderBy(x => x.Title);
            return _mapper.Map<List<ProductCategoryListViewModel>>(allProductCategories);
        }
    }
}
