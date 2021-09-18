using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenueByType
{
    public class GetMenuListQuery : IRequest<List<MenuByTypeViewModel>>
    {
        public MenuType MenuType { get; set; }
    }
}
