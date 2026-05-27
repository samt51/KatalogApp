using AutoMapper;
using KatalogApp.Application.Features.CategoryFeature.Dtos;
using KatalogApp.Application.Features.ColorsFeature.Dtos;

using KatalogApp.Application.Features.MetalPurityFeature.Dtos;
using KatalogApp.Application.Features.MetalTypeFeature.Dtos;
using KatalogApp.Application.Features.ProductImageFeature.Dtos;
using KatalogApp.Application.Features.ProductMetalFeature.Dtos;

using KatalogApp.Application.Features.ProductsFeature.Dtos;
using KatalogApp.Application.Features.ProductStoneFeature.Dtos;
using KatalogApp.Application.Features.RolesFeature.Dtos;
using KatalogApp.Application.Features.StoneClarityFeature.Dtos;
using KatalogApp.Application.Features.StoneCutFeature.Dtos;
using KatalogApp.Application.Features.StoneTypeFeature.Dtos;
using KatalogApp.Application.Features.StoneSettingFeature.Dtos;
using KatalogApp.Application.Features.StoneScaleFeature.Dtos;
using KatalogApp.Application.Features.UnitsFeature.Dtos;
using KatalogApp.Application.Features.UsersFeature.Commands.Create;
using KatalogApp.Application.Features.UsersFeature.Dtos;
using KatalogApp.Domain.Entities;

namespace KatalogApp.Application.Common.Concrete.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, KatalogApp.Application.Features.CategoryFeature.Commands.Create.CreateCategoryCommandRequest>().ReverseMap();
            CreateMap<Colors, ColorsDto>().ReverseMap();
            CreateMap<MetalPurity, MetalPurityDto>().ReverseMap();
            CreateMap<MetalType, MetalTypeDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();
            CreateMap<ProductMetal, KatalogApp.Application.Features.ProductMetalFeature.Dtos.ProductMetalDto>().ReverseMap();
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<Products, KatalogApp.Application.Features.ProductsFeature.Queries.GetProductByCategoryId.GetProductByCategoryIdQueryResponse>()
                .ForMember(dest => dest.MetalPurityName, opt => opt.MapFrom(src => src.MetalPurity != null ? src.MetalPurity.Name : ""))
                  .ForMember(dest => dest.MetalColorName, opt => opt.MapFrom(src => src.MetalColor != null ? src.MetalColor.Name : ""))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : ""))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images.Select(i => i.ImageName).ToList()));
            CreateMap<ProductStone, KatalogApp.Application.Features.ProductStoneFeature.Dtos.ProductStoneDto>().ReverseMap();
            CreateMap<ProductStone, KatalogApp.Application.Features.ProductsFeature.Dtos.ProductStoneDto>()
                .ForMember(dest => dest.StoneName, opt => opt.MapFrom(src => src.Stone != null && src.Stone.StoneScale != null ? src.Stone.StoneScale.Name : ""))
                .ForMember(dest => dest.ClarityName, opt => opt.MapFrom(src => src.Clarity != null ? src.Clarity.Name : ""))
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color != null ? src.Color.Name : ""));
            CreateMap<ProductMetal, KatalogApp.Application.Features.ProductsFeature.Dtos.ProductMetalDto>()
                .ForMember(dest => dest.MetalTypeName, opt => opt.MapFrom(src => src.MetalType != null ? src.MetalType.Name : ""))
                .ForMember(dest => dest.MetalPurityName, opt => opt.MapFrom(src => src.MetalPurity != null ? src.MetalPurity.Name : ""));
            CreateMap<Roles, RolesDto>().ReverseMap();
            CreateMap<StoneClarity, StoneClarityDto>().ReverseMap();
            CreateMap<StoneCut, StoneCutDto>().ReverseMap();
            CreateMap<StoneType, StoneTypeDto>().ReverseMap();
            CreateMap<StoneScale, StoneScaleDto>().ReverseMap();
            CreateMap<StoneSetting, StoneSettingDto>()
                .ForMember(dest => dest.SettingType, opt => opt.MapFrom(src => src.Unit != null ? src.Unit.Name : null))
                .ReverseMap();
            CreateMap<Units, UnitsDto>().ReverseMap();
            CreateMap<Users, UsersDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.MembershipExpiryDate, opt => opt.MapFrom(src => src.SubscriptionEndDate))
                .ForMember(dest => dest.IsLocked, opt => opt.MapFrom(src => src.IsLocked))
                .ReverseMap();


            CreateMap<Users, CreateUsersCommandRequest>().ReverseMap();

            CreateMap<KatalogApp.Domain.Entities.UserPricingProfile, KatalogApp.Application.Features.UsersFeature.Dtos.UserPricingProfileDto>().ReverseMap();
            CreateMap<KatalogApp.Domain.Entities.UserStonePrice, KatalogApp.Application.Features.UsersFeature.Dtos.UserStonePriceDto>().ReverseMap();
            CreateMap<KatalogApp.Domain.Entities.UserPolishingCost, KatalogApp.Application.Features.UsersFeature.Dtos.UserPolishingCostDto>().ReverseMap();


            CreateMap<KatalogApp.Domain.Entities.Stone, KatalogApp.Application.Features.StoneFeature.Queries.GetAll.GetAllStoneQueryResponse>().ReverseMap();
            CreateMap<KatalogApp.Domain.Entities.Stone, KatalogApp.Application.Features.StoneFeature.Dtos.StoneDto>().ReverseMap();
            CreateMap<KatalogApp.Domain.Entities.Stone, KatalogApp.Application.Features.StoneFeature.Commands.Create.CreateStoneCommandRequest>().ReverseMap();
            CreateMap<KatalogApp.Domain.Entities.Stone, KatalogApp.Application.Features.StoneFeature.Commands.Update.UpdateStoneCommandRequest>().ReverseMap();

        }
    }
}




