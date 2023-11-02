using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Application.Features.Brands;
using Catalog.Application.Features.Products;
using Catalog.Application.Features.Types;
using Catalog.Domain.Entities;

namespace Catalog.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductBrand, BrandDto>().ReverseMap();
            CreateMap<ProductType, ProductTypeDto>().ReverseMap();


            CreateMap<ProductBrand, BrandViewModel>().ReverseMap();
            CreateMap<List<ProductBrand>, List<BrandViewModel>>().ReverseMap();

            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<List<Product>, List<ProductViewModel>>().ReverseMap();

            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();


            CreateMap<ProductType, ProductTypeViewModel>().ReverseMap();
            CreateMap<List<ProductType>, List<ProductTypeViewModel>>().ReverseMap();
        }
    }
}
