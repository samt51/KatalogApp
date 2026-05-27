using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.ProductStoneFeature.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Queries.GetAll
{
    public class GetAllProductStoneQueryHandler : IRequestHandler<GetAllProductStoneQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductStoneDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductStoneQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductStoneDto>>> Handle(GetAllProductStoneQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductStone>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<ProductStoneDto, KatalogApp.Domain.Entities.ProductStone>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductStoneDto>>().Success(mapped);
        }
    }
}

