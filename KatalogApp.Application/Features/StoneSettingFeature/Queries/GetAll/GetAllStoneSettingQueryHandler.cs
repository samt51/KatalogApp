using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.StoneSettingFeature.Dtos;

namespace KatalogApp.Application.Features.StoneSettingFeature.Queries.GetAll
{
    public class GetAllStoneSettingQueryHandler : IRequestHandler<GetAllStoneSettingQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneSettingDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneSettingQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneSettingDto>>> Handle(GetAllStoneSettingQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneSetting>()
                .GetAllAsync(x => !x.IsDeleted, include: q => q.Include(s => s.Unit), ct: cancellationToken);
            
            var mapped = _mapper.Map<StoneSettingDto, KatalogApp.Domain.Entities.StoneSetting>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<StoneSettingDto>>().Success(mapped);
        }
    }
}
