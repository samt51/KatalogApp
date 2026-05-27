using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Create
{
    public class CreateProductMetalCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int ProductId { get; set; }
        public int MetalTypeId { get; set; }
        public decimal Gram { get; set; }
    }
}
