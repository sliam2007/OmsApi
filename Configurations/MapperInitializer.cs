using AutoMapper;
using OmsApi.Data;
using OmsApi.Models;

namespace OmsApi.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<CreateOrder, CreateOrderDTO>().ReverseMap();
            CreateMap<OrderDetails, OrderDetailsDTO>().ReverseMap();
            CreateMap<OrderProduct, OrderProductDTO>().ReverseMap();
            CreateMap<CreateOrderResponse, CreateOrderResponseDTO>().ReverseMap();
        }
    }
}
