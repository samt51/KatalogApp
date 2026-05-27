using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.UnitsFeature.Dtos;

namespace KatalogApp.Application.Features.UnitsFeature.Queries.GetAll
{
    public class GetAllUnitsQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UnitsDto>>>
    {
    }
}


