using System;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentDetail
{
    public class CommentDetailViewModel
    {
        public Guid CommentId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Message { get; set; }

        public string WriterName { get; set; }

        public string WriterEmail { get; set; }

        public bool? IsConfirmed { get; set; }

        public PageAndPostDTO PageAndPost { get; set; }
        public Guid PageAndPostId { get; set; }

        public ProductDTO Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
