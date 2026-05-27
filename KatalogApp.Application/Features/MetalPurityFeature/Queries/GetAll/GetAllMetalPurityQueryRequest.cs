using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.MetalPurityFeature.Dtos;

namespace KatalogApp.Application.Features.MetalPurityFeature.Queries.GetAll
{
    public class GetAllMetalPurityQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalPurityDto>>>
    {
    }
}


