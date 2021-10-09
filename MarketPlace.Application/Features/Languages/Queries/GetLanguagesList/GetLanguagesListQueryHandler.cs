using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguagesList
{
    public class GetLanguagesListQueryHandler : IRequestHandler<GetLanguagesListQuery, List<LanguageListViewModel>>
    {
        private readonly IAsyncRepository<Language> _languageRepository;
        private readonly IMapper _mapper;

        public GetLanguagesListQueryHandler(IMapper mapper, IAsyncRepository<Language> languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<List<LanguageListViewModel>> Handle(GetLanguagesListQuery request, CancellationToken cancellationToken)
        {
            var allLanguages = (await _languageRepository.ListAllAsync()).OrderBy(x => x.CreatedDate);
            return _mapper.Map<List<LanguageListViewModel>>(allLanguages);
        }
    }
}
