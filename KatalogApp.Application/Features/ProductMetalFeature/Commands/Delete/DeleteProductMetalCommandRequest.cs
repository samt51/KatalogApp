using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Delete
{
    public class DeleteProductMetalCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
    }
}

