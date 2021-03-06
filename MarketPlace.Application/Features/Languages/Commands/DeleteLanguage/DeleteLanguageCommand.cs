using MediatR;
using System;

namespace MarketPlace.Application.Features.Languages.Commands.DeleteLanguage
{
    public class DeleteLanguageCommand : IRequest
    {
        public Guid LanguagId { get; set; }
    }
}
