using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Languages.Queries.GetLanguagesList
{
    public class GetLanguagesListQuery: IRequest<List<LanguageListViewModel>>
    {

    }
}
