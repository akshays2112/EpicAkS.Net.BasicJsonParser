``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i9-11900K 3.50GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.200-preview.21617.4
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|                                   Method |       Mean |    Error |   StdDev |     Median | Rank |  Gen 0 |  Gen 1 | Allocated |
|----------------------------------------- |-----------:|---------:|---------:|-----------:|-----:|-------:|-------:|----------:|
|      SystemTextJson_Serialize_TC_Strings |   244.8 ns |  0.46 ns |  0.43 ns |   245.0 ns |    1 | 0.0668 |      - |     560 B |
|      NewtonsoftJson_Serialize_TC_Strings |   465.2 ns |  0.99 ns |  0.82 ns |   465.2 ns |    2 | 0.2017 | 0.0005 |   1,688 B |
|             EpicAkS_Serialize_TC_Strings |   885.3 ns | 17.52 ns | 29.75 ns |   867.4 ns |    3 | 0.4778 | 0.0010 |   4,000 B |
| SystemTextJson_Serialize_TC_StringArrays | 1,222.8 ns |  3.70 ns |  3.46 ns | 1,222.2 ns |    4 | 0.2384 |      - |   2,008 B |
| NewtonsoftJson_Serialize_TC_StringArrays | 2,534.6 ns | 14.70 ns | 13.75 ns | 2,529.6 ns |    5 | 0.5951 | 0.0038 |   5,000 B |
|               Serialize2_TC_StringArrays | 4,388.2 ns | 14.16 ns | 13.25 ns | 4,385.0 ns |    6 | 5.2643 | 0.0610 |  44,056 B |
