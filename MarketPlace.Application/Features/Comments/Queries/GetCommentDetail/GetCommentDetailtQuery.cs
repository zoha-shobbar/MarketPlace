using MediatR;
using System;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentDetail
{
    public class GetCommentDetailtQuery : IRequest<CommentDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
