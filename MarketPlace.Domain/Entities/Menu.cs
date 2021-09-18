using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Menu : AuditableEntity
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public Menu? ParentMenu { get; set; }
        public Guid? ParentMenuId { get; set; }

        public string MenueTitle { get; set; }

        public string Description { get; set; }

        public MenuType MenuType { get; set; }

        public PageAndPost PageAndPost { get; set; }
        public Guid PageAndPostId { get; set; }

        public ICollection<Menu> MenusList { get; set; }
    }

    public enum MenuType
    {
        MainMenu,
        HeaderMenu,
        FooterMenu,
        SideMenu

    }
}
