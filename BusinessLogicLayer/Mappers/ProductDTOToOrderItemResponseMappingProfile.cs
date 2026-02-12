using AutoMapper;
using Basboosify.OrdersMicroservice.BusinessLogicLayer.DTO;
using Basboosify.OrdersMicroservice.DataAccessLayer.Entities;

namespace Basboosify.OrdersMicroservice.BusinessLogicLayer.Mappers;

public class ProductDTOToOrderItemResponseMappingProfile : Profile
{
    public ProductDTOToOrderItemResponseMappingProfile()
    {
        CreateMap<ProductDTO, OrderItemResponse>()
          .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName))
          .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category));
    }
}