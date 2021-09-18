using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByPageId
{
    public class GetCommentListQuery : IRequest<List<CommentListViewModel>>
    {
        public Guid PageId { get; set; }
    }
}
