using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.StoneScaleFeature.Dtos;

namespace KatalogApp.Application.Features.StoneScaleFeature.Queries.GetAll
{
    public class GetAllStoneScaleQueryHandler : IRequestHandler<GetAllStoneScaleQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneScaleDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneScaleQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneScaleDto>>> Handle(GetAllStoneScaleQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneScale>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<StoneScaleDto, KatalogApp.Domain.Entities.StoneScale>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneScaleDto>>().Success(mapped);
        }
    }
}

