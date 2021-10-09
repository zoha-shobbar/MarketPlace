using MediatR;
using System;

namespace MarketPlace.Application.Features.Galleries.Commands.CreateGallery
{
    public class CreateGalleryCommand : IRequest<Guid>
    {
        public Guid GalleryId { get; set; }

        public string Title { get; set; }

        public string FileType { get; set; }

        public string FileExtention { get; set; }

        public float FileSize { get; set; }

        public bool? IsMasterImage { get; set; }

        public string AlterText { get; set; }

        public string DescriptionTextForSeo { get; set; }

        public Guid? PageAndPostId { get; set; }

        public Guid? ProductId { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
