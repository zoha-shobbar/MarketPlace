using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByProductId
{
    public class GetCommentListQuery : IRequest<List<CommentListByProductIdViewModel>>
    {
        public Guid ProductId { get; set; }
    }
}
