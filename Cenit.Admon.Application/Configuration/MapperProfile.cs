using AutoMapper;
using Cenit.Admon.Application.DTO;
using Cenit.Admon.Domain.Entities.Customers;

namespace Cenit.Admon.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CustomersEntity, CustomerDto>().ReverseMap();

        }
    }
}
