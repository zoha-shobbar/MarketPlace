using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.ProductCategories.Queries.GetProductCategoryDetail
{
    public class GetProductCategoryDetailQueryHandler : IRequestHandler<GetProductCategoryDetailQuery, ProductCategoryDetailViewModel>
    {
        private readonly IAsyncRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public GetProductCategoryDetailQueryHandler(IMapper mapper, 
                                                    IAsyncRepository<ProductCategory> productCategoryRepository)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<ProductCategoryDetailViewModel> Handle(GetProductCategoryDetailQuery request, 
                                                                 CancellationToken cancellationToken)
        {
            var productCategory = await _productCategoryRepository.GetByIdAsync(request.Id);
            var productCategoryDetailDto = _mapper.Map<ProductCategoryDetailViewModel>(productCategory);

            return productCategoryDetailDto;
        }
    }
}
