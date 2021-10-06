using MediatR;
using System;

namespace MarketPlace.Application.Features.Menues.Commands.DeleteMenu
{
    public class DeleteMenuCommand : IRequest
    {
        public Guid MenuId { get; set; }
    }
}
