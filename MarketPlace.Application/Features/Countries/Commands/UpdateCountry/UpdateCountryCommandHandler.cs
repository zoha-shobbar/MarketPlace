using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Commands.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand>
    {
        private readonly IAsyncRepository<Country> _countryRepository;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(IMapper mapper, IAsyncRepository<Country> countryRepository)
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
        }

        public async Task<Unit> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {

            var countryToUpdate = await _countryRepository.GetByIdAsync(request.CountryId);

            if (countryToUpdate == null)
            {
                throw new NotFoundException(nameof(Country), request.CountryId);
            }

            var validator = new UpdateCountryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, countryToUpdate, typeof(UpdateCountryCommand), typeof(Country));

            await _countryRepository.UpdateAsync(countryToUpdate);

            return Unit.Value;
        }
    }
}