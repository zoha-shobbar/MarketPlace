using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentDetail
{
    public class GetCommentDetailHandler : IRequestHandler<GetCommentDetailtQuery, CommentDetailViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Comment> _commentRepository;
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IAsyncRepository<Product> _productRepository;

        public GetCommentDetailHandler(IMapper mapper,
                                       IAsyncRepository<Comment> commentRepository,
                                       IAsyncRepository<PageAndPost> pageAndPostRepository,
                                       IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _commentRepository = commentRepository;
            _pageAndPostRepository = pageAndPostRepository;
            _productRepository = productRepository;
        }

        public async Task<CommentDetailViewModel> Handle(GetCommentDetailtQuery request, CancellationToken cancellationToken)
        {

            var @comment = await _commentRepository.GetByIdAsync(request.Id);
            var CommentDetailDTO = _mapper.Map<CommentDetailViewModel>(@comment);

            var pageAndPost = @comment.PageAndPostId != Guid.Empty ? await _pageAndPostRepository.GetByIdAsync((Guid)@comment!.PageAndPostId) : null;
            var product = @comment.ProductId != Guid.Empty ? _productRepository.GetByIdAsync((Guid)@comment.ProductId) : null;

            CommentDetailDTO.PageAndPost = _mapper.Map<PageAndPostDTO>(pageAndPost);
            CommentDetailDTO.Product = _mapper.Map<ProductDTO>(product);

            return CommentDetailDTO;
        }
    }
}
