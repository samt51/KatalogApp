using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.MetalTypeFeature.Commands.Create;
using KatalogApp.Application.Features.MetalTypeFeature.Commands.Update;
using KatalogApp.Application.Features.MetalTypeFeature.Commands.Delete;
using KatalogApp.Application.Features.MetalTypeFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetalTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MetalTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllMetalTypeQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateMetalTypeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateMetalTypeCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteMetalTypeCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
