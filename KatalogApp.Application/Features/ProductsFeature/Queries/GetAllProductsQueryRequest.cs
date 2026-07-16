using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.ProductsFeature.Dtos;
using MediatR;
using System.Collections.Generic;

namespace KatalogApp.Application.Features.ProductsFeature.Queries
{
    public class GetAllProductsQueryRequest : IRequest<ResponseDto<List<ProductDto>>>
    {
        public string? Code { get; set; }
        public string? Category { get; set; }
        public decimal? MinGram { get; set; }
        public decimal? MaxGram { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int? MetalTypeId { get; set; }
        public int? ClarityId { get; set; }
        public int? StoneId { get; set; }
        public int? StoneTypeId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int? ColumnIndex { get; set; }
        public string? OrderBy { get; set; }
    }
}
