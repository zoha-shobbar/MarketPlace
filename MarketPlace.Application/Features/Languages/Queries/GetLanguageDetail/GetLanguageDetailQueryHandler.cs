using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguageDetail
{
    public class GetLanguageDetailQueryHandler : IRequestHandler<GetLanguageDetailQuery, LanguageDetailViewModel>
    {
        private readonly IAsyncRepository<Language> _eventRepository;
        private readonly IMapper _mapper;

        public GetLanguageDetailQueryHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _eventRepository = languageRepository;
        }

        public async Task<LanguageDetailViewModel> Handle(GetLanguageDetailQuery request, CancellationToken cancellationToken)
        {
            var @language = await _eventRepository.GetByIdAsync(request.Id);
            var languageDetailDto = _mapper.Map<LanguageDetailViewModel>(@language);

            return languageDetailDto;
        }
    }
}
