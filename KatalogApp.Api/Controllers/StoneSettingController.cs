using KatalogApp.Application.Features.StoneSettingFeature.Commands.Create;
using KatalogApp.Application.Features.StoneSettingFeature.Commands.Delete;
using KatalogApp.Application.Features.StoneSettingFeature.Commands.Update;
using KatalogApp.Application.Features.StoneSettingFeature.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoneSettingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoneSettingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllStoneSettingQueryRequest());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStoneSettingCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateStoneSettingCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteStoneSettingCommandRequest { Id = id });
            return Ok(result);
        }
    }
}
