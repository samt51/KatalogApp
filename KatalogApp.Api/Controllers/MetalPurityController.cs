using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.MetalPurityFeature.Commands.Create;
using KatalogApp.Application.Features.MetalPurityFeature.Commands.Update;
using KatalogApp.Application.Features.MetalPurityFeature.Commands.Delete;
using KatalogApp.Application.Features.MetalPurityFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetalPurityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MetalPurityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllMetalPurityQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMetalPurityCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateMetalPurityCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteMetalPurityCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
