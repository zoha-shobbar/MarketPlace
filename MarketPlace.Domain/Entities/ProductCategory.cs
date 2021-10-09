
using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
   public class ProductCategory: AuditableEntity
    {
        public Guid ProductCategoryId { get; set; }
        
        public string Title { get; set; }

        public string ShorTitle { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
