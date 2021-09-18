using MediatR;
using System;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountryDetail
{
    public class GetEventDetailQuery : IRequest<CountryDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
