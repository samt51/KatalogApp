using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.StoneClarityFeature.Commands.Create;
using KatalogApp.Application.Features.StoneClarityFeature.Commands.Update;
using KatalogApp.Application.Features.StoneClarityFeature.Commands.Delete;
using KatalogApp.Application.Features.StoneClarityFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneClarityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoneClarityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllStoneClarityQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStoneClarityCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStoneClarityCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteStoneClarityCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
