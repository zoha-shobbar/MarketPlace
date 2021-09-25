using MediatR;
using System;

namespace MarketPlace.Application.Features.Languages.Commands.CreateLanguage
{
    public class CreateLanguageCommand : IRequest<Guid>
    {
        public string ShortTitle { get; set; }

        public string Title { get; set; }

        public string TitleWithOrginalLanguage { get; set; }

        public override string ToString()
        {
            return $"language :{Title};Short Title:{ShortTitle},Title With Orginal Language:{TitleWithOrginalLanguage}";
        }
    }
}
