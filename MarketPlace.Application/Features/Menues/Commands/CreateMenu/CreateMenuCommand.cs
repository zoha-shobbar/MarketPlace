using MediatR;
using System;

namespace MarketPlace.Application.Features.Menues.Commands.CreateMenu
{
    public class CreateMenuCommand : IRequest<Guid>
    {
        public Guid MenuId { get; set; }

        public int Sort { get; set; }

        public Guid? ParentMenuId { get; set; }

        public string MenueTitle { get; set; }

        public string? Description { get; set; }

        public int MenuType { get; set; }

        public Guid PageAndPostId { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
