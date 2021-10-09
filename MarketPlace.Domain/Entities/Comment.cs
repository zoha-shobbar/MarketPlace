using MarketPlace.Domain.Common;
using System;
using System.Collections.Generic;

namespace MarketPlace.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public Guid CommentId { get; set; }

        public string Message { get; set; }

        public string WriterName { get; set; }

        public string WriterEmail { get; set; }

        public bool? IsConfirmed { get; set; }

        public Comment? ReplyComment { get; set; }
        public Guid? ReplyCommentId { get; set; }

        public PageAndPost? PageAndPost { get; set; }
        public Guid? PageAndPostId { get; set; }


        public Product? Product { get; set; }
        public Guid? ProductId { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
