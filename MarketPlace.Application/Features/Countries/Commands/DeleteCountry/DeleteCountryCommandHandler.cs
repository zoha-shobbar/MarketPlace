using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand>
    {
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IMapper _mapper;

        public DeleteCountryCommandHandler(IMapper mapper, IAsyncRepository<Country> countryRepository)
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
        }

        public async Task<Unit> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            var countryToDelete = await _countryRepository.GetByIdAsync(request.CountryId);

            if (countryToDelete == null)
            {
                throw new NotFoundException(nameof(Country), request.CountryId);
            }

            await _countryRepository.DeleteAsync(countryToDelete);

            return Unit.Value;
        }
    }
}
