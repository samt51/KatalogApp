using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.StoneTypeFeature.Dtos;

namespace KatalogApp.Application.Features.StoneTypeFeature.Queries.GetAll
{
    public class GetAllStoneTypeQueryHandler : IRequestHandler<GetAllStoneTypeQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneTypeDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneTypeDto>>> Handle(GetAllStoneTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneType>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<StoneTypeDto, KatalogApp.Domain.Entities.StoneType>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneTypeDto>>().Success(mapped);
        }
    }
}

