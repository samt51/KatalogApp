using MediatR;
namespace KatalogApp.Application.Features.StoneClarityFeature.Commands.Update
{
    public class UpdateStoneClarityCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

