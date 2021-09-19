using MediatR;
using System;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguageDetail
{
    public class GetLanguageDetailQuery: IRequest<LanguageDetailViewModel>
    {
        public Guid Id { get; set; }
    }
}
