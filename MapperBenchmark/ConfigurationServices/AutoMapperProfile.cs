using AutoMapper;
using MapperBenchmark.Models;

namespace MapperBenchmark.ConfigurationServices;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.ToUpper()));
    }
}