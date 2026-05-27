using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.ProductMetalFeature.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Queries.GetAll
{
    public class GetAllProductMetalQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductMetalDto>>>
    {
    }
}


