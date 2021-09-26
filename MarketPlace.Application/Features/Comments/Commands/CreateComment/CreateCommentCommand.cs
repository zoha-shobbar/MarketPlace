using MediatR;
using System;

namespace MarketPlace.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommand : IRequest<Guid>
    {
        public Guid CommentId { get; set; }

        public string Message { get; set; }

        public string WriterName { get; set; }

        public string WriterEmail { get; set; }

        public bool? IsConfirmed { get; set; }

        public Guid? ReplyCommentId { get; set; }

        public Guid PageAndPostId { get; set; }

        public Guid ProductId { get; set; }

        public string UserId { get; set; }

        //public override string ToString()
        //{
        //    return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        //}
    }
}
