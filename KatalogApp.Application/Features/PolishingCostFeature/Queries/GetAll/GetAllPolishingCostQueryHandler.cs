
using AutoMapper;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KatalogApp.Application.Features.PolishingCostFeature.Dtos;

namespace KatalogApp.Application.Features.PolishingCostFeature.Queries.GetAll
{
    public class GetAllPolishingCostQueryHandler : IRequestHandler<GetAllPolishingCostQueryRequest, GetAllPolishingCostQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllPolishingCostQueryHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }
        public async Task<GetAllPolishingCostQueryResponse> Handle(GetAllPolishingCostQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.GetReadRepository<PolishingCost>()
                .GetAllAsync(predicate: x => !x.IsDeleted, include: q => q.Include(x => x.Category), ct: cancellationToken);

            return new GetAllPolishingCostQueryResponse
            {
                PolishingCosts = data.Select(x => new PolishingCostDto {
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    CategoryName = x.Category?.Name,
                    CostPrice = x.CostPrice,
                }).ToList()
            };
        }
    }
}
