


```ini

BenchmarkDotNet=v0.9.7.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770K CPU 3.50GHz, ProcessorCount=8
Frequency=3415987 ticks, Resolution=292.7412 ns, Timer=TSC
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
JitModules=clrjit-v4.6.1080.0

```

## List vs Collection

Results:

* **Initialization**
  
  
               Method |       Mode | Platform |       Jit | LaunchCount | WarmupCount | TargetCount |        Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------- |----------- |--------- |---------- |------------ |------------ |------------ |-------------- |---------- |------ |------ |------ |------------------- |
 InitializeCollection |  SingleRun |     Host |      Host |           1 |           1 |           1 | 2,341.9300 ns | 0.0000 ns |     - |     - |     - |         142,756.00 |
       InitializeList |  SingleRun |     Host |      Host |           1 |           1 |           1 | 1,756.4500 ns | 0.0000 ns |     - |     - |     - |         142,972.00 |
 InitializeCollection | Throughput |      X64 | LegacyJit |        Auto |        Auto |        Auto |    10.7221 ns | 0.0675 ns |  0.00 |     - |     - |              31.45 |
       InitializeList | Throughput |      X64 | LegacyJit |        Auto |        Auto |        Auto |     6.4995 ns | 0.4193 ns |  0.00 |     - |     - |              17.11 |
 InitializeCollection | Throughput |      X64 |    RyuJit |        Auto |        Auto |        Auto |    10.6899 ns | 0.0954 ns |  0.00 |     - |     - |              32.29 |
       InitializeList | Throughput |      X64 |    RyuJit |        Auto |        Auto |        Auto |     6.8553 ns | 0.3120 ns |  0.00 |     - |     - |              16.27 |
 InitializeCollection | Throughput |      X86 | LegacyJit |        Auto |        Auto |        Auto |    12.8012 ns | 0.5432 ns |  0.00 |     - |     - |              16.94 |
       InitializeList | Throughput |      X86 | LegacyJit |        Auto |        Auto |        Auto |     8.7641 ns | 1.0367 ns |  0.00 |     - |     - |              10.70 |

* **Add elements**  

            Method |       Mode | Platform |       Jit | LaunchCount | WarmupCount | TargetCount |    Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
------------------ |----------- |--------- |---------- |------------ |------------ |------------ |---------- |---------- |------ |------ |------ |------------------- |
 TestAddCollection |  SingleRun |     Host |      Host |           1 |           1 |           1 | 1.7565 us | 0.0000 us |     - |     - |     - |         179,018.67 |
       TestAddList |  SingleRun |     Host |      Host |           1 |           1 |           1 | 1.1710 us | 0.0000 us |     - |     - |     - |         179,018.67 |
	   
* **Find elements**  

           Method |       Mode | Platform |       Jit | LaunchCount | WarmupCount | TargetCount |        Median |     StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------- |----------- |--------- |---------- |------------ |------------ |------------ |-------------- |----------- |------ |------ |------ |------------------- |
 FindOnCollection |  SingleRun |     Host |      Host |           1 |           1 |           1 | 7,904.0100 ns |  0.0000 ns |     - |     - |     - |         181,741.33 |
       FindOnList |  SingleRun |     Host |      Host |           1 |           1 |           1 | 7,025.7900 ns |  0.0000 ns |     - |     - |     - |         181,752.00 |
 FindOnCollection | Throughput |      X64 | LegacyJit |        Auto |        Auto |        Auto |   374.4809 ns |  1.0266 ns |  0.00 |     - |     - |              69.87 |
       FindOnList | Throughput |      X64 | LegacyJit |        Auto |        Auto |        Auto |   296.4170 ns | 13.6333 ns |  0.00 |     - |     - |              43.61 |
 FindOnCollection | Throughput |      X64 |    RyuJit |        Auto |        Auto |        Auto |   389.4108 ns |  9.6807 ns |  0.00 |     - |     - |              55.09 |
       FindOnList | Throughput |      X64 |    RyuJit |        Auto |        Auto |        Auto |   288.8550 ns |  4.3045 ns |  0.00 |     - |     - |              48.15 |
 FindOnCollection | Throughput |      X86 | LegacyJit |        Auto |        Auto |        Auto |   893.3327 ns | 11.4807 ns |  0.00 |     - |     - |              33.92 |
       FindOnList | Throughput |      X86 | LegacyJit |        Auto |        Auto |        Auto |   789.4653 ns | 13.2522 ns |  0.00 |     - |     - |              23.85 |


