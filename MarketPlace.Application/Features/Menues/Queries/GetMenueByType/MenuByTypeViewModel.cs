using MarketPlace.Application.DTOs;
using MarketPlace.Application.Features.Menues.Queries.GetMenuList;
using System;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenueByType
{
    public class MenuByTypeViewModel
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public string MenueTitle { get; set; }

        public string Description { get; set; }

        public PageAndPostDTO PageAndPost { get; set; }
    }
}
