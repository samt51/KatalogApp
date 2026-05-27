using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.ProductImageFeature.Dtos;

namespace KatalogApp.Application.Features.ProductImageFeature.Queries.GetAll
{
    public class GetAllProductImageQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductImageDto>>>
    {
    }
}


