using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.MetalTypeFeature.Dtos;

namespace KatalogApp.Application.Features.MetalTypeFeature.Queries.GetAll
{
    public class GetAllMetalTypeQueryHandler : IRequestHandler<GetAllMetalTypeQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalTypeDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllMetalTypeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalTypeDto>>> Handle(GetAllMetalTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.MetalType>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<MetalTypeDto, KatalogApp.Domain.Entities.MetalType>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<MetalTypeDto>>().Success(mapped);
        }
    }
}

