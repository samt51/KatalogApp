using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.StoneScaleFeature.Dtos;

namespace KatalogApp.Application.Features.StoneScaleFeature.Queries.GetAll
{
    public class GetAllStoneScaleQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneScaleDto>>>
    {
    }
}


