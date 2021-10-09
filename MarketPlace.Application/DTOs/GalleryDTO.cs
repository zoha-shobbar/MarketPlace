using System;

namespace MarketPlace.Application.DTOs
{
    public class GalleryDTO
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string FileType { get; set; }

        public string FileExtention { get; set; }

        public float FileSize { get; set; }

        public bool? IsMasterImage { get; set; }

        public string AlterText { get; set; }

        public string DescriptionTextForSeo { get; set; }
    }
}