using MediatR;
using System;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuDetail
{
    public class GetMenuDetailQuery : IRequest<MenuDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
