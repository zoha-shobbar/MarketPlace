using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.DTOs;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleryDetail
{
    public class GetGalleryDetailQueryHandler : IRequestHandler<GetGalleryDetailQuery, GalleryDetailViewModel>
    {
        private readonly IAsyncRepository<Gallery> _galleryRepository;
        private readonly IAsyncRepository<PageAndPost> _pageAndPostRepository;
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public GetGalleryDetailQueryHandler(IMapper mapper, IAsyncRepository<Gallery> galleryRepository,
                                                            IAsyncRepository<PageAndPost> pageAndPostRepository,
                                                            IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _galleryRepository = galleryRepository;
            _pageAndPostRepository = pageAndPostRepository;
            _productRepository = productRepository;
        }

        public async Task<GalleryDetailViewModel> Handle(GetGalleryDetailQuery request, CancellationToken cancellationToken)
        {
            var @gallery = await _galleryRepository.GetByIdAsync(request.Id);
            var galleryDetailDto = _mapper.Map<GalleryDetailViewModel>(@gallery);

            var product = await _productRepository.GetByIdAsync((Guid)@gallery.ProductId);
            var pageAndPost = await _pageAndPostRepository.GetByIdAsync((Guid)@gallery.PageAndPostId);

            galleryDetailDto.Product = _mapper.Map<ProductDTO>(product);
            galleryDetailDto.PageAndPost = _mapper.Map<PageAndPostDTO>(pageAndPost);

            return galleryDetailDto;
        }
    }
}
