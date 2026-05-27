using MediatR;
namespace KatalogApp.Application.Features.ProductImageFeature.Commands.Update
{
    public class UpdateProductImageCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

