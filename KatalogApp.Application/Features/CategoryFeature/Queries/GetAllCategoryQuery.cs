using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.CategoryFeature.Dtos;
using MediatR;

namespace KatalogApp.Application.Features.CategoryFeature.Queries
{
    public class GetAllCategoryQuery : IRequest<ResponseDto<List<CategoryDto>>>
    {
    }
}

