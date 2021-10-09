using MediatR;
using System;

namespace MarketPlace.Application.Features.Languages.Commands.UpdateLanguage
{
    public class UpdateLanguageCommand : IRequest
    {
        public Guid LanguageId { get; set; }
      
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }
    }
}
