using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByProductId
{
    public class GetCommentListHandler : IRequestHandler<GetCommentListQuery, List<CommentListByProductIdViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public GetCommentListHandler(IMapper mapper, ICommentRepository commentRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
        }
        public async Task<List<CommentListByProductIdViewModel>> Handle(GetCommentListQuery request, CancellationToken cancellationToken)
        {
            var productComments = (await _commentRepository.GetByProductIdAsync(request.ProductId)).OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<CommentListByProductIdViewModel>>(productComments);
        }
    }
}
