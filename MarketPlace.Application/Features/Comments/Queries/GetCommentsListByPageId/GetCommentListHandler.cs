using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByPageId
{
    public class GetCommentListHandler : IRequestHandler<GetCommentListQuery, List<CommentListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public GetCommentListHandler(IMapper mapper, ICommentRepository commentRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }
        public async Task<List<CommentListViewModel>> Handle(GetCommentListQuery request, CancellationToken cancellationToken)
        {
            var productComments = (await _commentRepository.GetByPageIdAsync(request.PageId)).OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<CommentListViewModel>>(productComments);
        }
    }
}
