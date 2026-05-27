using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Features.UsersFeature.Dtos;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.UsersFeature.Queries.GetAll
{
    public class GetAllUsersQueryRequest : IRequest<ResponseDto<List<UsersDto>>>
    {
    }
}
