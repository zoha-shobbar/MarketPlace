using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByProductId
{
    public class GetCommentListQuery : IRequest<List<CommentListViewModel>>
    {
        public Guid ProductId { get; set; }
    }
}
