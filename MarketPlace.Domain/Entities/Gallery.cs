using MarketPlace.Domain.Common;
using System;

namespace MarketPlace.Domain.Entities
{
    public class Gallery : AuditableEntity
    {
        public Guid GalleryId { get; set; }

        public string Title { get; set; }

        public string FileType { get; set; }

        public string FileExtention { get; set; }

        public float FileSize { get; set; }

        public bool? IsMasterImage { get; set; }

        public string AlterText { get; set; }

        public string DescriptionTextForSeo { get; set; }

        public PageAndPost? PageAndPost { get; set; }
        public Guid? PageAndPostId { get; set; }

        public Product? Product { get; set; }
        public Guid? ProductId { get; set; }
    }
}
