using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.ProductCategories.Commands.UpdateProductCategory
{
    public class UpdateProductCategoryCommandHandler : IRequestHandler<UpdateProductCategoryCommand>
    {
        private readonly IAsyncRepository<ProductCategory> _productCategoryRepository;
        private readonly IMapper _mapper;

        public UpdateProductCategoryCommandHandler(IMapper mapper, IAsyncRepository<ProductCategory> productCategoryRepository)
        {
            _mapper = mapper;
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<Unit> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {

            var productCategoryToUpdate = await _productCategoryRepository.GetByIdAsync(request.ProductCategoryId);

            if (productCategoryToUpdate == null)
            {
                throw new NotFoundException(nameof(ProductCategory), request.ProductCategoryId);
            }

            var validator = new UpdateProductCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, productCategoryToUpdate, typeof(UpdateProductCategoryCommand), typeof(ProductCategory));

            await _productCategoryRepository.UpdateAsync(productCategoryToUpdate);

            return Unit.Value;
        }
    }
}