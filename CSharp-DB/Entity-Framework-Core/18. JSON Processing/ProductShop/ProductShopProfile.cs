using AutoMapper;
using ProductShop.Dtos.Input;
using ProductShop.Dtos.Output;
using ProductShop.Models;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            //Problem 01
            CreateMap<UserInputDto, User>();

            //Problem 02
            CreateMap<ProductImputDto, Product>();

            //Problem 03
            CreateMap<CategoryInputDto, Category>();
            CreateMap<Category, CategoryInputDto>();

            //Problem 04
            CreateMap<CategoryProductInputDto, CategoryProduct>();

            //Problem 06
            CreateMap<Product, ProductOutputDto>()
                .ForMember(dest => dest.Seller, opt => opt.MapFrom(src => $"{src.Seller.FirstName} {src.Seller.LastName}"));
        }
    }
}
