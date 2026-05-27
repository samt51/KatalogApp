using MediatR;
namespace KatalogApp.Application.Features.CategoryFeature.Commands.Update
{
    public class UpdateCategoryCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}


