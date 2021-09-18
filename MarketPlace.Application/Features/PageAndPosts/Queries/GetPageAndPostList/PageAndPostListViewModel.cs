using System;
using static MarketPlace.Domain.Entities.PageAndPost;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostList
{
    public class PageAndPostListViewModel
    {
        public Guid PageAndPostId { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string URL { get; set; }

        public string PageTitle { get; set; }

        public PagePublishSatus PublishStatus { get; set; }

        public bool? IsPage { get; set; }

        public bool? AllowComment { get; set; }
    }
}
