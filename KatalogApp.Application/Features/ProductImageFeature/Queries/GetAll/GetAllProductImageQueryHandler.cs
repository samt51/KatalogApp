using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.ProductImageFeature.Dtos;

namespace KatalogApp.Application.Features.ProductImageFeature.Queries.GetAll
{
    public class GetAllProductImageQueryHandler : IRequestHandler<GetAllProductImageQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductImageDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductImageQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductImageDto>>> Handle(GetAllProductImageQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductImage>().GetAllAsync(x => !x.IsDeleted, ct: cancellationToken);
            
            var mapped = _mapper.Map<ProductImageDto, KatalogApp.Domain.Entities.ProductImage>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<ProductImageDto>>().Success(mapped);
        }
    }
}

