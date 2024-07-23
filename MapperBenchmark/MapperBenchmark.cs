using AutoMapper;
using BenchmarkDotNet.Attributes;
using MapperBenchmark.ConfigurationServices;
using MapperBenchmark.Models;
using Mapster;

namespace MapperBenchmark;

public class MapperBenchmark
{
    private readonly List<User> _users;
    private readonly IMapper _mapper;

    public MapperBenchmark()
    {
        _users = Enumerable.Range(1, 1000).Select(i => new User
        {
            Id = i,
            Name = $"User {i}",
            Email = $"user{i}@example.com"
        }).ToList();

        var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
        _mapper = config.CreateMapper();
    }

    [Benchmark]
    public List<UserDto> MapsterBenchmark()
    {
        return _users.Adapt<List<UserDto>>();
    }

    [Benchmark]
    public List<UserDto> AutoMapperBenchmark()
    {
        return _mapper.Map<List<UserDto>>(_users);
    }
}