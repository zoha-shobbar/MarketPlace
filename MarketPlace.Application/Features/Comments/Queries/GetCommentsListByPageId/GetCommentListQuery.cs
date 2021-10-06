using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByPageId
{
    public class GetCommentListQuery : IRequest<List<CommentListByPageIdViewModel>>
    {
        public Guid PageId { get; set; }
    }
}
