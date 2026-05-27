using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.StoneClarityFeature.Dtos;

namespace KatalogApp.Application.Features.StoneClarityFeature.Queries.GetAll
{
    public class GetAllStoneClarityQueryHandler : IRequestHandler<GetAllStoneClarityQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneClarityDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneClarityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneClarityDto>>> Handle(GetAllStoneClarityQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneClarity>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<StoneClarityDto, KatalogApp.Domain.Entities.StoneClarity>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneClarityDto>>().Success(mapped);
        }
    }
}

