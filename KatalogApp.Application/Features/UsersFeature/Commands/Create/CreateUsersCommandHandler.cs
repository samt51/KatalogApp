using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Helpers;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.UsersFeature.Commands.Create
{
    public class CreateUsersCommandHandler : IRequestHandler<CreateUsersCommandRequest, ResponseDto<CreateUsersCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateUsersCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CreateUsersCommandResponse>> Handle(CreateUsersCommandRequest request, CancellationToken cancellationToken)
        {

            var datIsControll = await _unitOfWork.GetReadRepository<Users>().FindAsync(c => !c.IsDeleted && c.Email == request.Email && c.PhoneNumber == request.PhoneNumber);

            if (datIsControll is not null)
            {
                return new ResponseDto<CreateUsersCommandResponse>().Fail("Bu email adresi veya telefon numarası zaten kayıtlı.");
            }

            request.Password = PasswordHash.HashPassword(request.Password);
            request.RoleId = 3;
            var map = _mapper.Map<Users>(request);



            
            if (request.CustomMilyem.HasValue || request.SalesMultiplier.HasValue) {
                map.PricingProfile = new UserPricingProfile { CustomMilyem = request.CustomMilyem, SalesMultiplier = request.SalesMultiplier };
            }
            if (request.CustomStonePrices != null && request.CustomStonePrices.Any()) {
                map.CustomStonePrices = request.CustomStonePrices.Select(x => new UserStonePrice { StoneId = x.StoneId, CustomPrice = x.CustomPrice, CustomSettingPrice = x.CustomSettingPrice }).ToList();
            }
            if (request.CustomPolishingCosts != null && request.CustomPolishingCosts.Any()) {
                map.CustomPolishingCosts = request.CustomPolishingCosts.Select(x => new UserPolishingCost { CategoryId = x.CategoryId, CustomPrice = x.CustomPrice }).ToList();
            }

            await _unitOfWork.GetWriteRepository<Users>().AddAsync(map, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<CreateUsersCommandResponse>().Success();
        }
    }
}
