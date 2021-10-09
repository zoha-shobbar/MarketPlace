using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Exceptions;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand>
    {
        private readonly IAsyncRepository<Language> _languagRepository;
        private readonly IMapper _mapper;

        public DeleteLanguageCommandHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _languagRepository = languageRepository;
        }

        public async Task<Unit> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
        {
            var languageToDelete = await _languagRepository.GetByIdAsync(request.LanguagId);

            if (languageToDelete == null)
            {
                throw new NotFoundException(nameof(Language), request.LanguagId);
            }

            await _languagRepository.DeleteAsync(languageToDelete);

            return Unit.Value;
        }
    }
}
