using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.MetalTypeFeature.Dtos;

namespace KatalogApp.Application.Features.MetalTypeFeature.Queries.GetAll
{
    public class GetAllMetalTypeQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalTypeDto>>>
    {
    }
}


