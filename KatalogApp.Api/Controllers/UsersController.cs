using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.UsersFeature.Commands.Create;
using KatalogApp.Application.Features.UsersFeature.Commands.Update;
using KatalogApp.Application.Features.UsersFeature.Commands.Delete;
using KatalogApp.Application.Features.UsersFeature.Queries.GetAll;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllUsersQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<ResponseDto<CreateUsersCommandResponse>> Create(CreateUsersCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut]
        public async Task<ResponseDto<UpdateUsersCommandResponse>> Update(UpdateUsersCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteUsersCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
