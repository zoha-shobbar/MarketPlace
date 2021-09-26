using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommandHandler : IRequestHandler<CreateProductCategoryCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IProductCategoryRepository _productCategoryRepository;

        public CreateProductCategoryCommandHandler(IMapper mapper, IProductCategoryRepository productCategoryRepository)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<Guid> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategorylanguage = _mapper.Map<ProductCategory>(request);
            productCategorylanguage = await _productCategoryRepository.AddAsync(productCategorylanguage);
            return productCategorylanguage.ProductCategoryId;
        }
    }
}
