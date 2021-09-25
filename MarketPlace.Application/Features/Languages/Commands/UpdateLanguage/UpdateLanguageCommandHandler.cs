using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Features.Languages.Commands.CreateLanguage;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Language> _languageRepository;

        public UpdateLanguageCommandHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }
        public async Task<Unit> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
        {
            var languageToUpdate = await _languageRepository.GetByIdAsync(request.LanguageId);
            _mapper.Map(request, languageToUpdate, typeof(UpdateLanguageCommand), typeof(Language));
            await _languageRepository.UpdateAsync(languageToUpdate);
            return Unit.Value;
        }
    }
}
