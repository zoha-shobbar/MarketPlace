using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Products.Commands.DeleteProducts
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IAsyncRepository<Product> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IMapper mapper, IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _eventRepository = productRepository;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.ProductId);

            if (eventToDelete == null)
            {
                throw new NotFoundException(nameof(Product), request.ProductId);
            }

            await _eventRepository.DeleteAsync(eventToDelete);

            return Unit.Value;
        }
    }
}
