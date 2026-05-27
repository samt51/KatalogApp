using MediatR;
using System.Collections.Generic;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.CategoryFeature.Commands.UpdateOrder
{
    public class UpdateCategoryOrderDto
    {
        public int Id { get; set; }
        public int OrderIndex { get; set; }
    }

    public class UpdateCategoryOrderCommandRequest : IRequest<ResponseDto<bool>>
    {
        public List<UpdateCategoryOrderDto> Categories { get; set; } = new List<UpdateCategoryOrderDto>();
    }
}
