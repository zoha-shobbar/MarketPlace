using MediatR;
using System;

namespace MarketPlace.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommand : IRequest
    {
        public Guid CountryId { get; set; }
    }
}
