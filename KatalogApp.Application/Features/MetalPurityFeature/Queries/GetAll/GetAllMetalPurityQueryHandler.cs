using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.MetalPurityFeature.Dtos;

namespace KatalogApp.Application.Features.MetalPurityFeature.Queries.GetAll
{
    public class GetAllMetalPurityQueryHandler : IRequestHandler<GetAllMetalPurityQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalPurityDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllMetalPurityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalPurityDto>>> Handle(GetAllMetalPurityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.MetalPurity>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<MetalPurityDto, KatalogApp.Domain.Entities.MetalPurity>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalPurityDto>>().Success(mapped);
        }
    }
}

