
using KatalogApp.Application.Features.PolishingCostFeature.Commands.Create;
using KatalogApp.Application.Features.PolishingCostFeature.Commands.Delete;
using KatalogApp.Application.Features.PolishingCostFeature.Commands.Update;
using KatalogApp.Application.Features.PolishingCostFeature.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolishingCostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PolishingCostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllPolishingCostQueryRequest());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePolishingCostCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePolishingCostCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeletePolishingCostCommandRequest { Id = id });
            return Ok(result);
        }
    }
}
