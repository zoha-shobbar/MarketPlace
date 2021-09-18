using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Products.Queries.GetProductList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductsListViewModel>>
    {
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IMapper mapper, IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<List<ProductsListViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var allproducts = (await _productRepository.ListAllAsync()).OrderBy(x => x.CreatedDate).OrderBy(x => x.Title);
            return _mapper.Map<List<ProductsListViewModel>>(allproducts);
        }
    }
}
