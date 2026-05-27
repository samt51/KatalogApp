using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.ProductMetalFeature.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Queries.GetAll
{
    public class GetAllProductMetalQueryHandler : IRequestHandler<GetAllProductMetalQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductMetalDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductMetalQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductMetalDto>>> Handle(GetAllProductMetalQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductMetal>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<ProductMetalDto, KatalogApp.Domain.Entities.ProductMetal>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductMetalDto>>().Success(mapped);
        }
    }
}

