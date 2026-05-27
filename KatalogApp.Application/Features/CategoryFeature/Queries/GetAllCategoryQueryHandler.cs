using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.CategoryFeature.Dtos;
using KatalogApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// Not: GerÃ§ek projede bir IRepository veya DbContext arayÃ¼zÃ¼ inject edilmelidir.
// Åimdilik doÄŸrudan handler yapÄ±sÄ±nÄ± kuruyoruz. EÄŸer DbContext kullanacaksanÄ±z buraya eklenecektir.
namespace KatalogApp.Application.Features.CategoryFeature.Queries
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, ResponseDto<List<CategoryDto>>>
    {
        // private readonly IKatalogDbContext _context; // DbContext baÄŸÄ±mlÄ±lÄ±ÄŸÄ± buraya gelecek

        public GetAllCategoryQueryHandler() 
        {
        }

        public async Task<ResponseDto<List<CategoryDto>>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            // Ã–rnek: var categories = await _context.Categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name }).ToListAsync();
            var categories = new List<CategoryDto>(); 
            
            return new ResponseDto<List<CategoryDto>>().Success(categories);
        }
    }
}


