using MediatR;
namespace KatalogApp.Application.Features.ProductStoneFeature.Commands.Update
{
    public class UpdateProductStoneCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

