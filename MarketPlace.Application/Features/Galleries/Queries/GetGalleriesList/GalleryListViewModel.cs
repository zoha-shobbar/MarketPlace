using MarketPlace.Application.DTOs;
using System;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleriesList
{
    public class GalleryListViewModel
    {
        public Guid GalleryId { get; set; }

        public string Title { get; set; }

        public string FileExtention { get; set; }

        public float FileSize { get; set; }

        public PageAndPostDTO? PageAndPost { get; set; }
        public Guid? PageAndPostId { get; set; }

        public ProductDTO? Product { get; set; }
        public Guid? ProductId { get; set; }
    }
}
