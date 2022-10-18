using AutoMapper;
using Client.Register.Domain.Dto.Customer;
using Client.Register.Domain.Entity;

namespace Client.Register.CrossCutting.Mapping;

public class CustumerMapping : Profile
{
    public CustumerMapping()
    {
        CreateMap<CustomerDto, CustomerEntity>().ReverseMap();
        CreateMap<CustomerDtoCreate, CustomerEntity>().ReverseMap();
        CreateMap<CustomerDtoUpdate, CustomerEntity>().ReverseMap();
    }
}