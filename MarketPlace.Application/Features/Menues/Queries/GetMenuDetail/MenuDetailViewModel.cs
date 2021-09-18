using MarketPlace.Domain.Entities;
using System;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuDetail
{
    public class MenuDetailViewModel
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public string MenueTitle { get; set; }

        public string Description { get; set; }

        public MenuType MenuType { get; set; }
    }
}
