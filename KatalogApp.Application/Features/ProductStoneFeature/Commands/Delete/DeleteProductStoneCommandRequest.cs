using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Commands.Delete
{
    public class DeleteProductStoneCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
    }
}

