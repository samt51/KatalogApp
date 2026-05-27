using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.UserActionLogFeature.Dtos;
using KatalogApp.Domain.Entities;

namespace KatalogApp.Application.Features.UserActionLogFeature.Queries.GetAll
{
    public class GetAllUserActionLogQueryHandler : IRequestHandler<GetAllUserActionLogQueryRequest, KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UserActionLogDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUserActionLogQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UserActionLogDto>>> Handle(GetAllUserActionLogQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<UserActionLog>().GetAllAsync(
                x => !x.IsDeleted,
                include: y => y.Include(x => x.User).Include(x => x.Product),
                ct: cancellationToken);
                
            
            var mapped = _mapper.Map<UserActionLogDto, UserActionLog>(data);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<System.Collections.Generic.List<UserActionLogDto>>().Success(mapped);
        }
    }
}

