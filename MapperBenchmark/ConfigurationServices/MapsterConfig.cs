using MapperBenchmark.Models;
using Mapster;

namespace MapperBenchmark.ConfigurationServices;

public static class MapsterConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<User, UserDto>.NewConfig()
            .Map(dest => dest.Name, src => src.Name.ToUpper());
    }
}