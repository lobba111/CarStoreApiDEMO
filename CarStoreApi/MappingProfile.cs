using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace CarStoreApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Måste styra min order mapping, tror att min record och class är olika då vissa värden får vara null
            //i min fråga så behöver jag nog mappa det object jag skickar in och konvertera min product dto till product 
            //så jag behöver se över mina service och repo samt controller
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>();
            CreateMap<Product, ProductDto>().ReverseMap();
            
        }
    }
}
