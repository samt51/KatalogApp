using KatalogApp.Application.Features.ProductsFeature.Commands.Create;
using KatalogApp.Application.Features.ProductsFeature.Commands.Update;
using KatalogApp.Application.Features.ProductsFeature.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var response = await _mediator.Send(new KatalogApp.Application.Features.ProductsFeature.Queries.GetProductByCategoryId.GetProductByCategoryIdQueryRequest { CategoryId = categoryId });
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new KatalogApp.Application.Features.ProductsFeature.Commands.Delete.DeleteProductCommandRequest { Id = id });
            return Ok(response);
        }

        [HttpPost("import-excel")]
        public async Task<IActionResult> ImportExcel()
        {
            var response = await _mediator.Send(new KatalogApp.Application.Features.ProductsFeature.Commands.ImportExcel.ImportExcelCommandRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}


