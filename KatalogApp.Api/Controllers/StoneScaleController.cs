using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.StoneScaleFeature.Commands.Create;
using KatalogApp.Application.Features.StoneScaleFeature.Commands.Update;
using KatalogApp.Application.Features.StoneScaleFeature.Commands.Delete;
using KatalogApp.Application.Features.StoneScaleFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneScaleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoneScaleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllStoneScaleQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStoneScaleCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStoneScaleCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteStoneScaleCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
