using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.StoneTypeFeature.Commands.Create;
using KatalogApp.Application.Features.StoneTypeFeature.Commands.Update;
using KatalogApp.Application.Features.StoneTypeFeature.Commands.Delete;
using KatalogApp.Application.Features.StoneTypeFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoneTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllStoneTypeQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStoneTypeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStoneTypeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteStoneTypeCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
