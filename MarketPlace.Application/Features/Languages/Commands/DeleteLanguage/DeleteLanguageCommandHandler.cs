using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.DeleteLanguage
{
    public class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Language> _languageRepository;
        public DeleteLanguageCommandHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<Unit> Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
        {
            var languageToDelete = await _languageRepository.GetByIdAsync(request.LanguageId);
            await _languageRepository.DeleteAsync(languageToDelete);
            return Unit.Value;
        }
    }
}
