using System;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguageDetail
{
    public class LanguageDetailViewModel
    {
        public Guid LanguageId { get; set; }
      
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

    }
}
