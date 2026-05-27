using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Delete
{
    public class DeleteStoneCommandRequest : IRequest<ResponseDto<DeleteStoneCommandResponse>>
    {
        public int Id { get; set; }
    }
}

