using MediatR;
namespace KatalogApp.Application.Features.StoneCutFeature.Commands.Update
{
    public class UpdateStoneCutCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

