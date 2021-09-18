using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostList
{
    public class PageAndPostsListQuery : IRequest<List<PageAndPostListViewModel>>
    {

    }
}
