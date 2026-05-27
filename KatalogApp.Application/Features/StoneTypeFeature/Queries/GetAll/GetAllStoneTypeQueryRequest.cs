using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.StoneTypeFeature.Dtos;

namespace KatalogApp.Application.Features.StoneTypeFeature.Queries.GetAll
{
    public class GetAllStoneTypeQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneTypeDto>>>
    {
    }
}


