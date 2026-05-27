using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.StoneSettingFeature.Dtos;

namespace KatalogApp.Application.Features.StoneSettingFeature.Queries.GetAll
{
    public class GetAllStoneSettingQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneSettingDto>>>
    {
    }
}
