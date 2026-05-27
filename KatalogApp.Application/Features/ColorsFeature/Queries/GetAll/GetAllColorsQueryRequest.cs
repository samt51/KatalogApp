using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.ColorsFeature.Dtos;

namespace KatalogApp.Application.Features.ColorsFeature.Queries.GetAll
{
    public class GetAllColorsQueryRequest : IRequest<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ColorsDto>>>
    {
    }
}


