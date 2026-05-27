using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.RolesFeature.Dtos;

namespace KatalogApp.Application.Features.RolesFeature.Queries.GetAll
{
    public class GetAllRolesQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<RolesDto>>>
    {
    }
}


