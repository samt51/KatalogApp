using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.ProductMetalFeature.Commands.Create;
using KatalogApp.Application.Features.ProductMetalFeature.Commands.Update;
using KatalogApp.Application.Features.ProductMetalFeature.Commands.Delete;
using KatalogApp.Application.Features.ProductMetalFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMetalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductMetalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllProductMetalQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductMetalCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductMetalCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteProductMetalCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
