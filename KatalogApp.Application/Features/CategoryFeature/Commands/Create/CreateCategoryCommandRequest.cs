using KatalogApp.Application.Core.Dtos;
using MediatR;
namespace KatalogApp.Application.Features.CategoryFeature.Commands.Create
{
    public class CreateCategoryCommandRequest : IRequest<ResponseDto<CreateCategoryCommandResponse>>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}


