using System;

namespace MarketPlace.Application.DTOs
{
    public class PageAndPostDTO
    {
        public Guid PageAndPostId { get; set; }
        public string Title { get; set; }
        public string PageTitle { get; set; }
        public string URL { get; set; }
    }
}
