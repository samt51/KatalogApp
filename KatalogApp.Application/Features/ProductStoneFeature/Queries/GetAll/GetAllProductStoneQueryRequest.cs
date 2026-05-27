using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.ProductStoneFeature.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Queries.GetAll
{
    public class GetAllProductStoneQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductStoneDto>>>
    {
    }
}


