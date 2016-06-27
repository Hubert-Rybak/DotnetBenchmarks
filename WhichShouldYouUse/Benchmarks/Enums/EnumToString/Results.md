```ini

BenchmarkDotNet=v0.9.7.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770K CPU 3.50GHz, ProcessorCount=8
Frequency=3415987 ticks, Resolution=292.7412 ns, Timer=TSC
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
JitModules=clrjit-v4.6.1080.0

Type=EnumBenchmark  Mode=Throughput

```


## Enum extension methods with custom ToString() for enum members



                                   Method |         Median |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------------------------------- |--------------- |----------- |------- |------ |------ |------------------- |
          EnumToStringWithCustomAttribute | 10,714.5650 ns | 75.3359 ns | 100.00 |     - |     - |             342.13 |
 EnumToStringWithCustomAttributeWithCache |  1,159.4627 ns |  8.5413 ns |  17.68 |     - |     - |              52.00 |
               EnumToStringWithDictionary |    117.9858 ns |  0.6993 ns |  11.07 |     - |     - |              32.45 |


As easy to expect, converting `Enum` to specific string with `Dictionary` is fastest. It's also hardest to maintain, as it requires storing `Dictionary` objects somewhere in your code apart from enum.  
    Best alternative is to use attribute like `DescriptionAttribute`. It's consistent, because all string representations or enum values are bound to the respective enum members.
