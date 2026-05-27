using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.StoneCutFeature.Dtos;

namespace KatalogApp.Application.Features.StoneCutFeature.Queries.GetAll
{
    public class GetAllStoneCutQueryHandler : IRequestHandler<GetAllStoneCutQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneCutDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneCutQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneCutDto>>> Handle(GetAllStoneCutQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneCut>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<StoneCutDto, KatalogApp.Domain.Entities.StoneCut>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneCutDto>>().Success(mapped);
        }
    }
}

