using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Language : AuditableEntity
    {
        public Guid LanguageId { get; set; }
    
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public ICollection<Country> Countries { get; set; }
        public ICollection<PageAndPost> PageAndPosts { get; set; }
    }
}
