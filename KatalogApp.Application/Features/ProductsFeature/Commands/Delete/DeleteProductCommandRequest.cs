using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.Delete
{
    public class DeleteProductCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
    }
}
