using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.CategoryFeature.Dtos;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.CategoryFeature.Queries.GetAll
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, ResponseDto<List<CategoryDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<CategoryDto>>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Category>().GetAllAsync(x => !x.IsDeleted, orderBy: q => q.OrderBy(c => c.OrderIndex), ct: cancellationToken);
            var mapped = _mapper.Map<CategoryDto, KatalogApp.Domain.Entities.Category>(data);
            return new ResponseDto<List<CategoryDto>>().Success(mapped);
        }
    }
}
