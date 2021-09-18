using MarketPlace.Application.DTOs;
using System;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleryDetail
{
    public class GalleryDetailViewModel
    {
        public Guid GalleryId { get; set; }

        public string Title { get; set; }

        public string FileType { get; set; }

        public string FileExtention { get; set; }

        public string FileSize { get; set; }

        public bool? IsMasterImage { get; set; }

        public string AlterText { get; set; }

        public string DescriptionTextForSeo { get; set; }

        public PageAndPostDTO? PageAndPost { get; set; }
        public Guid? PageAndPostId { get; set; }

        public ProductDTO? Product { get; set; }
        public Guid? ProductId { get; set; }
    }
}
