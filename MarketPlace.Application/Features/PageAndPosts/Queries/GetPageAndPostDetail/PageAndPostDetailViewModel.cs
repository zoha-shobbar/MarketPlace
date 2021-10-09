using System;
using System.Collections.Generic;
using static MarketPlace.Domain.Entities.PageAndPost;

namespace MarketPlace.Application.Features.PageAndPosts.Queries.GetPageAndPostDetail
{
    public class PageAndPostDetailViewModel
    {
        public Guid PageAndPostId { get; set; }

        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string URL { get; set; }

        public string PageTitle { get; set; }

        public PagePublishSatus PublishStatus { get; set; }

        public bool? IsPage { get; set; }

        public bool AllowComment { get; set; }

        public string CreatedBy { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }
        
        public DateTime LastModified { get; set; }
        
        public virtual ICollection<GalleryDTO> Gallery{ get; set; }
    }
}
