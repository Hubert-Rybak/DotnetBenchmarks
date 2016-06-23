
# Which should you use?
Project inspired by various Stack Overflow questions regarding performance of core .NET objects.  
For example, what is faster: `List<T>` or `Collection<T>` ? 

Benchmarking enviroment:

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
  
  
               Method |       Mode | Platform |       Jit | Framework | Runtime | LaunchCount | WarmupCount | TargetCount |        Median |    StdDev |          Mean |  StdError |    StdDev |         Op/s |           Min |            Q1 |        Median |            Q3 |           Max | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------- |----------- |--------- |---------- |---------- |-------- |------------ |------------ |------------ |-------------- |---------- |-------------- |---------- |---------- |------------- |-------------- |-------------- |-------------- |-------------- |-------------- |------ |------ |------ |------------------- |
 InitializeCollection |  SingleRun |     Host |      Host |      Host |    Host |           1 |           1 |           1 | 1,756.4500 ns | 0.0000 ns | 1,756.4500 ns | 0.0000 ns | 0.0000 ns |    569330.18 | 1,756.4500 ns | 1,756.4500 ns | 1,756.4500 ns | 1,756.4500 ns | 1,756.4500 ns |     - |     - |     - |         145,814.67 |
       InitializeList |  SingleRun |     Host |      Host |      Host |    Host |           1 |           1 |           1 | 1,463.7100 ns | 0.0000 ns | 1,463.7100 ns | 0.0000 ns | 0.0000 ns |    683195.44 | 1,463.7100 ns | 1,463.7100 ns | 1,463.7100 ns | 1,463.7100 ns | 1,463.7100 ns |     - |     - |     - |         143,249.33 |
 InitializeCollection | Throughput |      X64 |      Host |       V40 |     Clr |        Auto |        Auto |        Auto |            NA |        NA |            NA |        NA |        NA |           NA |            NA |            NA |            NA |            NA |            NA |   N/A |   N/A |   N/A |                N/A |
       InitializeList | Throughput |      X64 |      Host |       V40 |     Clr |        Auto |        Auto |        Auto |            NA |        NA |            NA |        NA |        NA |           NA |            NA |            NA |            NA |            NA |            NA |   N/A |   N/A |   N/A |                N/A |
 InitializeCollection | Throughput |      X64 |      Host |      V452 |     Clr |        Auto |        Auto |        Auto |    12.0221 ns | 0.2546 ns |    12.0924 ns | 0.0326 ns | 0.2546 ns |  82696587.55 |    11.7731 ns |    11.9258 ns |    12.0221 ns |    12.1823 ns |    13.1808 ns |  0.00 |     - |     - |              29.88 |
       InitializeList | Throughput |      X64 |      Host |      V452 |     Clr |        Auto |        Auto |        Auto |     7.6742 ns | 0.0876 ns |     7.6815 ns | 0.0098 ns | 0.0876 ns | 130183242.13 |     7.4852 ns |     7.6381 ns |     7.6742 ns |     7.7209 ns |     7.9312 ns |  0.00 |     - |     - |              17.96 |
 InitializeCollection | Throughput |      X64 |      Host |      V462 |     Clr |        Auto |        Auto |        Auto |    12.0115 ns | 0.1050 ns |    12.0202 ns | 0.0136 ns | 0.1050 ns |  83193216.61 |    11.8299 ns |    11.9562 ns |    12.0115 ns |    12.0756 ns |    12.3421 ns |  0.00 |     - |     - |              29.88 |
       InitializeList | Throughput |      X64 |      Host |      V462 |     Clr |        Auto |        Auto |        Auto |     7.6818 ns | 0.5214 ns |     7.7958 ns | 0.0583 ns | 0.5214 ns | 128274038.08 |     7.5216 ns |     7.6270 ns |     7.6818 ns |     7.7510 ns |    11.1518 ns |  0.00 |     - |     - |              17.48 |
 InitializeCollection | Throughput |      X64 | LegacyJit |      Host |    Host |        Auto |        Auto |        Auto |    12.0280 ns | 0.3681 ns |    12.1295 ns | 0.0440 ns | 0.3681 ns |  82443624.83 |    11.6893 ns |    11.8752 ns |    12.0280 ns |    12.3248 ns |    14.0638 ns |  0.00 |     - |     - |              32.15 |
       InitializeList | Throughput |      X64 | LegacyJit |      Host |    Host |        Auto |        Auto |        Auto |     7.8707 ns | 0.4053 ns |     7.8560 ns | 0.0427 ns | 0.4053 ns | 127291107.03 |     7.4954 ns |     7.6543 ns |     7.8707 ns |     7.9524 ns |    11.2947 ns |  0.00 |     - |     - |              15.59 |
 InitializeCollection | Throughput |      X64 |    RyuJit |      Host |    Host |        Auto |        Auto |        Auto |    12.4119 ns | 0.2395 ns |    12.3349 ns | 0.0309 ns | 0.2395 ns |  81070904.29 |    11.9425 ns |    12.0982 ns |    12.4119 ns |    12.5362 ns |    12.8945 ns |  0.00 |     - |     - |              32.32 |
       InitializeList | Throughput |      X64 |    RyuJit |      Host |    Host |        Auto |        Auto |        Auto |     7.8316 ns | 0.5231 ns |     7.9172 ns | 0.0585 ns | 0.5231 ns | 126307902.17 |     7.5867 ns |     7.7114 ns |     7.8316 ns |     8.0297 ns |    12.2808 ns |  0.00 |     - |     - |              16.60 |
 InitializeCollection | Throughput |      X86 | LegacyJit |      Host |    Host |        Auto |        Auto |        Auto |    13.2310 ns | 0.2996 ns |    13.3114 ns | 0.0387 ns | 0.2996 ns |  75123718.53 |    12.9609 ns |    13.0638 ns |    13.2310 ns |    13.4969 ns |    14.2689 ns |  0.00 |     - |     - |              16.94 |
       InitializeList | Throughput |      X86 | LegacyJit |      Host |    Host |        Auto |        Auto |        Auto |     9.1111 ns | 0.2397 ns |     9.0783 ns | 0.0287 ns | 0.2397 ns | 110153316.75 |     8.6728 ns |     8.8613 ns |     9.1111 ns |     9.2548 ns |     9.6779 ns |  0.00 |     - |     - |              10.24 |



