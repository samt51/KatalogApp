using MediatR;
namespace KatalogApp.Application.Features.StoneCutFeature.Commands.Create
{
    public class CreateStoneCutCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

