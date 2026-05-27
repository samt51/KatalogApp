using MediatR;
using Microsoft.AspNetCore.Mvc;
using KatalogApp.Application.Features.UserActionLogFeature.Queries.GetAll;
using KatalogApp.Application.Features.UserActionLogFeature.Commands.Create;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActionLogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserActionLogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllUserActionLogQueryRequest());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserActionLogCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
