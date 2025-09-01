using AutoMapper;
using Basboosify.OrdersMicroservice.BusinessLogicLayer.DTO;
using Basboosify.OrdersMicroservice.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basboosify.OrdersMicroservice.BusinessLogicLayerr.Mappers;

public class OrderItemUpdateRequestToOrderItemMappingProfile : Profile
{
    public OrderItemUpdateRequestToOrderItemMappingProfile()
    {
        CreateMap<OrderItemUpdateRequest, OrderItem>()
          .ForMember(dest => dest.ProductID, opt => opt.MapFrom(src => src.ProductID))
          .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
          .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
          .ForMember(dest => dest.TotalPrice, opt => opt.Ignore())
          .ForMember(dest => dest._id, opt => opt.Ignore());
    }
}
