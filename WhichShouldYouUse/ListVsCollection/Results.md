


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
  
Mode=Throughput  

               Method |     Median |    StdDev |    Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------- |----------- |---------- |--------- |------ |------ |------------------- |
 InitializeCollection | 12.8557 ns | 0.2601 ns | 3,020.00 |     - |     - |              16.94 |
       InitializeList |  8.7589 ns | 0.2665 ns | 1,757.56 |     - |     - |               9.85 |

* **Add elements**  

Mode=SingleRun (other - Out of Memory)

            Method |        Median |    StdDev |           Max | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
------------------ |-------------- |---------- |-------------- |------ |------ |------ |------------------- |
 TestAddCollection | 1,463.7100 ns | 0.0000 ns | 1,463.7100 ns |     - |     - |     - |         179,018.67 |
       TestAddList |   878.2200 ns | 0.0000 ns |   878.2200 ns |     - |     - |     - |         179,018.67 |
	   
* **Find elements**  

Mode=Throughput  

           Method |      Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------- |------------ |---------- |------ |------ |------ |------------------- |
 FindOnCollection | 868.3073 ns | 2.2616 ns | 95.91 |     - |     - |              37.68 |
       FindOnList | 768.8471 ns | 5.7764 ns | 67.00 |     - |     - |              23.85 |


