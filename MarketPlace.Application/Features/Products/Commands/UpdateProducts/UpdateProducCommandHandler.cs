using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Exceptions;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProducCommandHandler : IRequestHandler<UpdateProducCommand>
    {
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public UpdateProducCommandHandler(IMapper mapper, IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProducCommand request, CancellationToken cancellationToken)
        {

            var producToUpdate = await _productRepository.GetByIdAsync(request.ProductId);

            if (producToUpdate == null)
            {
                throw new NotFoundException(nameof(Product), request.ProductId);
            }

            var validator = new UpdateProducCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, producToUpdate, typeof(UpdateProducCommand), typeof(Product));

            await _productRepository.UpdateAsync(producToUpdate);

            return Unit.Value;
        }
    }
}