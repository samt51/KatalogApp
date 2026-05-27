using MediatR;
namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Update
{
    public class UpdateProductMetalCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

