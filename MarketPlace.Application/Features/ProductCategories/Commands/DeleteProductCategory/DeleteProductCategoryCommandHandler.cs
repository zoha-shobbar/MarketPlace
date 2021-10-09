using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.ProductCategories.Commands.DeleteProductCategory
{
    public class DeleteProductCategoryCommandHandler : IRequestHandler<DeleteProductCategoryCommand>
    {
        private readonly IAsyncRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public DeleteProductCategoryCommandHandler(IMapper mapper, IAsyncRepository<ProductCategory> productCategoryRepository)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<Unit> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategoryToDelete = await _productCategoryRepository.GetByIdAsync(request.ProductCategoryId);

            if (productCategoryToDelete == null)
            {
                throw new NotFoundException(nameof(ProductCategory), request.ProductCategoryId);
            }

            await _productCategoryRepository.DeleteAsync(productCategoryToDelete);

            return Unit.Value;
        }
    }
}
