using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class PageAndPost : AuditableEntity
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

        public virtual ICollection<Gallery> Products { get; set; }
          
        public enum PagePublishSatus
        {
            Published,
            Draft,
            Pending,
            Private,
            Trash
        }
    }
}
