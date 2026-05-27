using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Queries.GetAll
{
    public class GetAllStoneQueryHandler : IRequestHandler<GetAllStoneQueryRequest, ResponseDto<List<GetAllStoneQueryResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStoneQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<GetAllStoneQueryResponse>>> Handle(GetAllStoneQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Stone>().GetAllAsync(x => !x.IsDeleted, include: q => Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.Include(Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.Include(q, x => x.StoneSetting), x => x.StoneScale), ct: cancellationToken);
            
            var mapped = _mapper.Map<List<GetAllStoneQueryResponse>>(data);
            return new ResponseDto<List<GetAllStoneQueryResponse>>().Success(mapped);
        }
    }
}

