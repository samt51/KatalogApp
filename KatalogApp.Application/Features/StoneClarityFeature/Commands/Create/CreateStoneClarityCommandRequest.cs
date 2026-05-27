using MediatR;
namespace KatalogApp.Application.Features.StoneClarityFeature.Commands.Create
{
    public class CreateStoneClarityCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

