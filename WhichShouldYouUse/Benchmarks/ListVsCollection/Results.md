


```ini

BenchmarkDotNet=v0.9.7.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770K CPU 3.50GHz, ProcessorCount=8
Frequency=3415987 ticks, Resolution=292.7412 ns, Timer=TSC
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE
JitModules=clrjit-v4.6.1080.0

```
Mode=Throughput  

## List vs Collection

* **Initialization**


               Method |     Median |    StdDev |    Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------- |----------- |---------- |--------- |------ |------ |------------------- |
 InitializeCollection | 12.8557 ns | 0.2601 ns | 3,020.00 |     - |     - |              16.94 |
       InitializeList |  8.7589 ns | 0.2665 ns | 1,757.56 |     - |     - |               9.85 |

* **Add elements**  


                     Method |      Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
--------------------------- |------------ |---------- |------ |------ |------ |------------------- |
 AddAndRemoveFromCollection | 366.9311 ns | 4.2355 ns |     - |     - |     - |               0.03 |
       AddAndRemoveFromList | 219.1629 ns | 3.7055 ns |     - |     - |     - |               0.03 |

* **Find elements**  


           Method |      Median |    StdDev | Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
----------------- |------------ |---------- |------ |------ |------ |------------------- |
 FindOnCollection | 868.3073 ns | 2.2616 ns | 95.91 |     - |     - |              37.68 |
       FindOnList | 768.8471 ns | 5.7764 ns | 67.00 |     - |     - |              23.85 |



Results show that Collection is not better from List in any way. In fact it is a bit slower due to fact that most of its methods are virtual. Moreover, Collection doesn't support many operations "out of the box" like List e.g. Find(), RemoveAll(Perdicate) and  so on.   Main point of Collection is to use it as base class for custom collection implementations.
