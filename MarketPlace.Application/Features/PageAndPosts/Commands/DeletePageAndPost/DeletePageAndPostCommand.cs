using MediatR;
using System;

namespace MarketPlace.Application.Features.PageAndPosts.Commands.DeletePageAndPost
{
    public class DeletePageAndPostCommand : IRequest
    {
        public Guid PageAndPostId { get; set; }
    }
}
