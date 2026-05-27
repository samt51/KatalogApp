using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.ProductsFeature.Dtos;
using MediatR;
using System.Collections.Generic;

namespace KatalogApp.Application.Features.ProductsFeature.Queries
{
    public class GetAllProductsQueryRequest : IRequest<ResponseDto<List<ProductDto>>>
    {
    }
}
