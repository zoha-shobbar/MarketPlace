using MediatR;
using System;

namespace MarketPlace.Application.Features.Countries.Queries.GetCountryDetail
{
    public class GetCountryDetailQuery : IRequest<CountryDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
