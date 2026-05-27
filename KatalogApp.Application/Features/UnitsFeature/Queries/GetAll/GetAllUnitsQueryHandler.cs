using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.UnitsFeature.Dtos;

namespace KatalogApp.Application.Features.UnitsFeature.Queries.GetAll
{
    public class GetAllUnitsQueryHandler : IRequestHandler<GetAllUnitsQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UnitsDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUnitsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UnitsDto>>> Handle(GetAllUnitsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Units>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<UnitsDto, KatalogApp.Domain.Entities.Units>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UnitsDto>>().Success(mapped);
        }
    }
}

