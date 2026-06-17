using KatalogApp.Application.Core.Dtos;
using MediatR;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.ImportExcel
{
    public class ImportExcelCommandRequest : IRequest<ResponseDto<bool>>
    {
    }
}
