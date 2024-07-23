using Mapster;
using MapsterExamples.Dtos;
using MapsterExamples.Models;

namespace MapsterExamples.ConfigureServices;

public static class MapsterConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<User, UserDto>.NewConfig()
            .Map(dest => dest.Name, src => src.Name.ToUpper());
    }
}