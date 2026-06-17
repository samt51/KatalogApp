using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using KatalogApp.Application.Features.ProductImageFeature.Commands.Create;

namespace KatalogApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file, [FromForm] int productId)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Geçersiz dosya.");

            // Create images/katalog directory if it doesn't exist
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "katalog");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            // Generate unique filename
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Save to DB
            var request = new CreateProductImageCommandRequest
            {
                ProductId = productId,
                ImageName = uniqueFileName
            };

            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("upload-temp")]
        public async Task<IActionResult> UploadTemp(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Geçersiz dosya.");

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "katalog");
            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new KatalogApp.Application.Core.Dtos.ResponseDto<string>().Success(uniqueFileName));
        }
    }
}
