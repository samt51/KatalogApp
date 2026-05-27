using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Core.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Create
{
    public class CreateStoneCommandHandler : IRequestHandler<CreateStoneCommandRequest, ResponseDto<CreateStoneCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStoneCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CreateStoneCommandResponse>> Handle(CreateStoneCommandRequest request, CancellationToken cancellationToken)
        {

            try
            {

      
            // Duplicate check removed since Name is removed

            var map = _mapper.Map<Stone>(request);
            map.CreatedDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<Stone>().AddAsync(map, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<CreateStoneCommandResponse>().Success();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
