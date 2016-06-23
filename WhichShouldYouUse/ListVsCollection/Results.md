


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
  
               Method |    Median |    StdDev |       Max | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------- |---------- |---------- |---------- |------ |------ |------ |------------------- |
 InitializeCollection | 1.7565 us | 0.0000 us | 1.7565 us |     - |     - |     - |         142,756.00 |
       InitializeList | 2.3419 us | 0.0000 us | 2.3419 us |     - |     - |     - |         142,972.00 |

* **Add elements**  

            Method |        Median |    StdDev |           Max | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
------------------ |-------------- |---------- |-------------- |------ |------ |------ |------------------- |
 TestAddCollection | 1,463.7100 ns | 0.0000 ns | 1,463.7100 ns |     - |     - |     - |         179,018.67 |
       TestAddList |   878.2200 ns | 0.0000 ns |   878.2200 ns |     - |     - |     - |         179,018.67 |
	   
* **Find elements**  

           Method |    Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------- |---------- |---------- |------ |------ |------ |------------------- |
 FindOnCollection | 9.6605 us | 0.0000 us |     - |     - |     - |         181,741.33 |
       FindOnList | 5.8548 us | 0.0000 us |     - |     - |     - |         181,752.00 |


