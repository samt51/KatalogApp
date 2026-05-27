using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.StoneClarityFeature.Dtos;

namespace KatalogApp.Application.Features.StoneClarityFeature.Queries.GetAll
{
    public class GetAllStoneClarityQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneClarityDto>>>
    {
    }
}


