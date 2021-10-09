using MediatR;
using System;

namespace MarketPlace.Application.Features.Menues.Commands.UpdateMenu
{
    public class UpdateMenuCommand : IRequest
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public Guid? ParentMenuId { get; set; }

        public string MenueTitle { get; set; }

        public string? Description { get; set; }

        public int MenuType { get; set; }

        public Guid PageAndPostId { get; set; }
    }
}
