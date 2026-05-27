using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Commands.Create
{
    public class CreateProductStoneCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int ProductId { get; set; }
        public int StoneId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Carat { get; set; }
        public decimal TotalCarat { get; set; }
    }
}
