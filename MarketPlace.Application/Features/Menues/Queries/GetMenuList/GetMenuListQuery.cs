using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuList

{
    public class GetMenuListQuery : IRequest<List<MenuListViewModel>>
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public string MenueTitle { get; set; }

        public string Description { get; set; }

        public MenuType MenuType { get; set; }
    }
}
