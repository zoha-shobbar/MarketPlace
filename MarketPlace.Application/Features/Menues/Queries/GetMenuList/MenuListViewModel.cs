using MarketPlace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Menues.Queries.GetMenuList
{
    public class MenuListViewModel
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public string MenueTitle { get; set; }

        public string Description { get; set; }

        public MenuType MenuType { get; set; }

        public PageAndPostDTO PageAndPost { get; set; }
        
        public ICollection<MenuListViewModel> MenusList { get; set; }
    }
}
