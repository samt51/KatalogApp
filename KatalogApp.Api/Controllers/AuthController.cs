using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.AuthFeature.Commands.Login;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
