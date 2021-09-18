using MediatR;
using System;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostDetail
{
    public class GetPageAndPostDetailQuery: IRequest<PageAndPostDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
