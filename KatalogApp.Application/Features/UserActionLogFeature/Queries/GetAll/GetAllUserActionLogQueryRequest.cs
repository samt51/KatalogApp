using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.UserActionLogFeature.Dtos;

namespace KatalogApp.Application.Features.UserActionLogFeature.Queries.GetAll
{
    public class GetAllUserActionLogQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UserActionLogDto>>>
    {
    }
}

