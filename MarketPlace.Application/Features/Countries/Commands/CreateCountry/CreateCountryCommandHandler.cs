using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Countries.Commands.CreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _countryRepository;

        public CreateCountryCommandHandler(IMapper mapper, ICountryRepository countryRepository)
        {
            _mapper = mapper;
            _countryRepository = countryRepository;
        }

        public async Task<Guid> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var country = _mapper.Map<Country>(request);
            country = await _countryRepository.AddAsync(country);
            return country.CountryId;
        }
    }
}
