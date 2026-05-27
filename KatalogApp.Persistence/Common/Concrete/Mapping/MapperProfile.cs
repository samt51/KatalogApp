using AutoMapper;
using KatalogApp.Application.Features.CategoryFeature.Commands.Create;
using KatalogApp.Domain.Entities;

namespace KatalogApp.Persistence.Common.Concrete.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CreateCategoryCommandRequest>().ReverseMap();
        }
    }
}
