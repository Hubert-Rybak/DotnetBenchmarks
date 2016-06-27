```ini

BenchmarkDotNet=v0.9.7.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770K CPU 3.50GHz, ProcessorCount=8
Frequency=3415985 ticks, Resolution=292.7413 ns, Timer=TSC
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
JitModules=clrjit-v4.6.1080.0

Type=BenchmarkObjectEnumVsRegular  Mode=Throughput  

```

## ObjectEnum vs Object with enum property

            Method |     Median |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
------------------ |----------- |---------- |------- |------ |------ |------------------- |
  CreateObjectEnum | 70.0126 ns | 2.8658 ns | 358.00 |     - |     - |               5.23 |
 CreateRegularEnum |  1.6177 ns | 3.5891 ns | 344.70 |     - |     - |               5.03 |
