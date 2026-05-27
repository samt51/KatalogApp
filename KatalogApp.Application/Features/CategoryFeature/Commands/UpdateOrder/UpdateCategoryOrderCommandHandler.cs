using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;
using System.Linq;

namespace KatalogApp.Application.Features.CategoryFeature.Commands.UpdateOrder
{
    public class UpdateCategoryOrderCommandHandler : IRequestHandler<UpdateCategoryOrderCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(UpdateCategoryOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var ids = request.Categories.Select(x => x.Id).ToList();
            var categories = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Category>().GetAllAsync(x => ids.Contains(x.Id), ct: cancellationToken);
            
            var list = categories.ToList();
            foreach (var cat in list)
            {
                var target = request.Categories.FirstOrDefault(x => x.Id == cat.Id);
                if (target != null)
                {
                    cat.OrderIndex = target.OrderIndex;
                    await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.Category>().UpdateAsync(cat, cancellationToken);
                }
            }

            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }
    }
}
