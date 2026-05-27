using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.StoneCutFeature.Dtos;

namespace KatalogApp.Application.Features.StoneCutFeature.Queries.GetAll
{
    public class GetAllStoneCutQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneCutDto>>>
    {
    }
}


