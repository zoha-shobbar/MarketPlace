using System;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguagesList
{
    public class LanguageListViewModel
    {
        public Guid LanguageId { get; set; }
        
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }
    }
}
