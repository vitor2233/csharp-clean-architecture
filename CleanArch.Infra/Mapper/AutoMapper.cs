
using AutoMapper;
using CleanArch.Domain.Model;
using CleanArch.Infra.Entity;

namespace CleanArch.Infra.Mapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Customer, CustomerEntity>()
            .ReverseMap()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        CreateMap<CustomerCreate, CustomerEntity>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}