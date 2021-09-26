using MediatR;
using System;

namespace MarketPlace.Application.Features.ProductCategories.Commands.CreateProductCategory
{
    public class CreateProductCategoryCommand : IRequest<Guid>
    {
        public Guid ProductCategoryId { get; set; }
        public string Title { get; set; }

        public string ShorTitle { get; set; }

        public string Description { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
