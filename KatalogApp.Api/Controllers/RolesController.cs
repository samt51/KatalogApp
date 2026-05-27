using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.RolesFeature.Commands.Create;
using KatalogApp.Application.Features.RolesFeature.Commands.Update;
using KatalogApp.Application.Features.RolesFeature.Commands.Delete;
using KatalogApp.Application.Features.RolesFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllRolesQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRolesCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateRolesCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteRolesCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
