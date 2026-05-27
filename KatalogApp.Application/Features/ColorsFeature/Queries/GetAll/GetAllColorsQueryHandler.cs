using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.ColorsFeature.Dtos;

namespace KatalogApp.Application.Features.ColorsFeature.Queries.GetAll
{
    public class GetAllColorsQueryHandler : IRequestHandler<GetAllColorsQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ColorsDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllColorsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ColorsDto>>> Handle(GetAllColorsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Colors>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<ColorsDto, KatalogApp.Domain.Entities.Colors>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ColorsDto>>().Success(mapped);
        }
    }
}

