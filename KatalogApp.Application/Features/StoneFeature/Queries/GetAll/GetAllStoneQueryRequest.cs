using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Queries.GetAll
{
    public class GetAllStoneQueryRequest : IRequest<ResponseDto<List<GetAllStoneQueryResponse>>>
    {
    }
}


