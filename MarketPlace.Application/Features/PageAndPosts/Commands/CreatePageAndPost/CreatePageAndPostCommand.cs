using MediatR;
using System;

namespace MarketPlace.Application.Features.PageAndPosts.Commands.CreatePageAndPost
{
    public class CreatePageAndPostCommand : IRequest<Guid>
    {
        public Guid PageAndPostId { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string URL { get; set; }

        public string PageTitle { get; set; }

        public int PublishStatus { get; set; }

        public bool? IsPage { get; set; }

        public bool AllowComment { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
