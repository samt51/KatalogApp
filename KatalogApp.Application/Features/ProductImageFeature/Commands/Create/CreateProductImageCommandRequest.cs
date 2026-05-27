using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductImageFeature.Commands.Create
{
    public class CreateProductImageCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int ProductId { get; set; }
        public string ImageName { get; set; }
    }
}
