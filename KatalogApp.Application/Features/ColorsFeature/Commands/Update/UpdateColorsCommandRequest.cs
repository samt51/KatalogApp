using MediatR;
namespace KatalogApp.Application.Features.ColorsFeature.Commands.Update
{
    public class UpdateColorsCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

