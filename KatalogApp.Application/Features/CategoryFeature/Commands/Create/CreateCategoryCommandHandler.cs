using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Domain.Entities;

namespace KatalogApp.Application.Features.CategoryFeature.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, ResponseDto<CreateCategoryCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CreateCategoryCommandResponse>> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {

            request.Name = request.Name.Trim().ToUpper();

            await _unitOfWork.GetReadRepository<Category>().GetDataNullControllAsync(c => !c.IsDeleted && c.Name == request.Name);

            var entity = _mapper.Map<Category, CreateCategoryCommandRequest>(request);


            await _unitOfWork.GetWriteRepository<Category>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateCategoryCommandResponse>().Success();

        }
    }
}

