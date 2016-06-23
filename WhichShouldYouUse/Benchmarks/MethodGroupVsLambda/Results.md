```ini

BenchmarkDotNet=v0.9.7.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i7-4770K CPU 3.50GHz, ProcessorCount=8
Frequency=3415988 ticks, Resolution=292.7411 ns, Timer=TSC
HostCLR=MS.NET 4.0.30319.42000, Arch=32-bit RELEASE [AttachedDebugger]
JitModules=clrjit-v4.6.1080.0

Type=MethodGroupVsLambdaInLoop  Mode=Throughput  

```
            Method |     Median |    StdDev |    Gen 0 | Gen 1 | Gen 2 | Bytes Allocated/Op |
------------------ |----------- |---------- |--------- |------ |------ |------------------- |
 MethodGroupInLoop | 36.9511 ns | 0.3677 ns | 7,358.00 |     - |     - |              76.97 |
      LambdaInLoop | 18.9907 ns | 0.4875 ns |        - |     - |     - |               0.00 |
	  
	  
	  
>The Method group version allocates a new object every single time it is run whereas the lambda version uses an instance (or static, as >necessary) field to cache the delegate.  
>More info:  

>http://vibrantcode.com/2013/02/19/lambdas-vs-method-groups/  
>http://blog.filipekberg.se/2013/02/15/optimize-your-delegate-usage/

