using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsList
{
    public class GetCommentListHandler : IRequestHandler<GetCommentListQuery, List<CommentListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Comment> _commentRepository;

        public GetCommentListHandler(IMapper mapper, IAsyncRepository<Comment> commentRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }
        public async Task<List<CommentListViewModel>> Handle(GetCommentListQuery request, CancellationToken cancellationToken)
        {
            var allComments = (await _commentRepository.ListAllAsync()).OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<CommentListViewModel>>(allComments);
        }
    }
}
