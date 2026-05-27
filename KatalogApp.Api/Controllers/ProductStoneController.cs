using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using KatalogApp.Application.Features.ProductStoneFeature.Commands.Create;
using KatalogApp.Application.Features.ProductStoneFeature.Commands.Update;
using KatalogApp.Application.Features.ProductStoneFeature.Commands.Delete;
using KatalogApp.Application.Features.ProductStoneFeature.Queries.GetAll;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStoneController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductStoneController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllProductStoneQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductStoneCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductStoneCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteProductStoneCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
