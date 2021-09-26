using AutoMapper;
using MarketPlace.Application.Contracts.Persistence;
using MarketPlace.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MarketPlace.Application.Features.Comments.Commands.CreateComment
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ILanguageRepository _languageRepository;

        public CreateCommentCommandHandler(IMapper mapper, ILanguageRepository languageRepository)
        {
            _mapper = mapper;
            _languageRepository = languageRepository;
        }

        public async Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = _mapper.Map<Language>(request);
            comment = await _languageRepository.AddAsync(comment);
            return comment.LanguageId;
        }
    }
}
