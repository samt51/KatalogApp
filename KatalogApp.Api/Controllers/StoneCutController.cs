using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.StoneCutFeature.Commands.Create;
using KatalogApp.Application.Features.StoneCutFeature.Commands.Update;
using KatalogApp.Application.Features.StoneCutFeature.Commands.Delete;
using KatalogApp.Application.Features.StoneCutFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneCutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoneCutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllStoneCutQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStoneCutCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateStoneCutCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteStoneCutCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
