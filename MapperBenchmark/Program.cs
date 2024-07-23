using BenchmarkDotNet.Running;
using MapperBenchmark.ConfigurationServices;

MapsterConfig.Configure();
_ = BenchmarkRunner.Run<MapperBenchmark.MapperBenchmark>();