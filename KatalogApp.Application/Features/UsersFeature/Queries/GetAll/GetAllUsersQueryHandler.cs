using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Features.UsersFeature.Dtos;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.UsersFeature.Queries.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, ResponseDto<List<UsersDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<List<UsersDto>>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Users>().GetAllAsync(x => !x.IsDeleted && x.RoleId == 3, 
                include: i => Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.Include(i, u => u.PricingProfile).Include(u => u.CustomStonePrices).Include(u => u.CustomPolishingCosts).Include(u => u.UserSettingPrices),
                ct: cancellationToken);
            var mapped = _mapper.Map<List<UsersDto>>(data);
            return new ResponseDto<List<UsersDto>>().Success(mapped);
        }
    }
}
