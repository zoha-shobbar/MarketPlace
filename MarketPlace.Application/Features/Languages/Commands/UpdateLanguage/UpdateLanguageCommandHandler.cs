using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Application.Exceptions;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Commands.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand>
    {
        private readonly IAsyncRepository<Language> _languageRepository;
        private readonly IMapper _mapper;

        public UpdateLanguageCommandHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<Unit> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
        {

            var languageToUpdate = await _languageRepository.GetByIdAsync(request.LanguageId);

            if (languageToUpdate == null)
            {
                throw new NotFoundException(nameof(Language), request.LanguageId);
            }

            var validator = new UpdateLanguageCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, languageToUpdate, typeof(UpdateLanguageCommand), typeof(Language));

            await _languageRepository.UpdateAsync(languageToUpdate);

            return Unit.Value;
        }
    }
}