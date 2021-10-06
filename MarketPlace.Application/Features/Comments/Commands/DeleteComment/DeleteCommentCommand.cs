using MediatR;
using System;

namespace MarketPlace.Application.Features.Comments.Commands.DeleteComment
{
    public class DeleteCommentCommand : IRequest
    {
        public Guid CommentId { get; set; }
    }
}
