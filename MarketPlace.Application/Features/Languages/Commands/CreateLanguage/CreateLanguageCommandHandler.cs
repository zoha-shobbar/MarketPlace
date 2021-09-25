using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.CreateLanguage
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _languageRepository;

        public CreateLanguageCommandHandler(IMapper mapper, ILanguageRepository languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<Guid> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
        {
            var @language = _mapper.Map<Language>(request);
            @language = await _languageRepository.AddAsync(@language);
            return @language.LanguageId;
        }
    }
}
