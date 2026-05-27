using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.CategoryFeature.Dtos;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.CategoryFeature.Queries.GetAll
{
    public class GetAllCategoryQueryRequest : IRequest<ResponseDto<List<CategoryDto>>>
    {
    }
}
