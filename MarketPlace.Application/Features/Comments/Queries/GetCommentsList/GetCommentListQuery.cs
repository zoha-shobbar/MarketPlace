using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsList
{
    public class GetCommentListQuery : IRequest<List<CommentListViewModel>>
    {
    }
}
