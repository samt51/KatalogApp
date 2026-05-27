using MediatR;
using KatalogApp.Application.Core.Dtos;
using System.Collections.Generic;

namespace KatalogApp.Application.Features.ProductsFeature.Queries.GetProductByCategoryId
{
    public class GetProductByCategoryIdQueryRequest : IRequest<ResponseDto<List<GetProductByCategoryIdQueryResponse>>>
    {
        public int CategoryId { get; set; }
    }
}
