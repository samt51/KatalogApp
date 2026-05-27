using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.CategoryFeature.Commands.Create;
using KatalogApp.Application.Features.CategoryFeature.Commands.Delete;
using KatalogApp.Application.Features.CategoryFeature.Commands.Update;
using KatalogApp.Application.Features.CategoryFeature.Queries.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {


                var response = await _mediator.Send(new GetAllCategoryQueryRequest());
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ResponseDto<CreateCategoryCommandResponse>> Create(CreateCategoryCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        
        [HttpPost("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(KatalogApp.Application.Features.CategoryFeature.Commands.UpdateOrder.UpdateCategoryOrderCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteCategoryCommandRequest { Id = id });
            return Ok(response);
        }
    }
}
