using MediatR;
namespace KatalogApp.Application.Features.CategoryFeature.Commands.Delete
{
    public class DeleteCategoryCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

