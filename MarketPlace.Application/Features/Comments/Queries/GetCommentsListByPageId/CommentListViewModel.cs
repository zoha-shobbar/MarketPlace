using System;

namespace MarketPlace.Application.Features.Comments.Queries.GetCommentsListByPageId
{
    public class CommentListViewModel
    {
        public Guid CommentId { get; set; }

        public string Message { get; set; }

        public string WriterName { get; set; }

        public string WriterEmail { get; set; }

        public bool? IsConfirmed { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
