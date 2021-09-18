using MediatR;
using System.Collections.Generic;

namespace MarketPlace.Application.Features.Galleries.Queries.GetGalleriesList
{
    public class GetGalleriesListQuery: IRequest<List<GalleryListViewModel>>
    {

    }
}
