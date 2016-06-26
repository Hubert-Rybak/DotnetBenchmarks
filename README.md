
# Which should you use?
This project was inspired by my collegue which stated that:
<br>
> *"Creation of __`List<T>`__ is expensive, use __`Collection<T>`__ instead."*  

So I decided to put it into test with excellent **BenchmarkDotNet** library.

## Benchamrk results
* [List\<T\> vs Collection\<T\>](WhichShouldYouUse/Benchmarks/ListVsCollection/Results.md)  
* [Method group vs Lambda in loop](WhichShouldYouUse/Benchmarks/MethodGroupVsLambda/Results.md)
* [Enum ToString() with custom values](WhichShouldYouUse/Benchmarks/Enums/Results.md)

<br>
>  *"Premature optimization is the root of all evil"* -- Donald Knuth 
