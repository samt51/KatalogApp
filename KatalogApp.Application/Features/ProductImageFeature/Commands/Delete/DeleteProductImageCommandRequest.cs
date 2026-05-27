using MediatR;
namespace KatalogApp.Application.Features.ProductImageFeature.Commands.Delete
{
    public class DeleteProductImageCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

