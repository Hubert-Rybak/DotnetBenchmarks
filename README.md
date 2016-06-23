
# Which should you use?
This project was inspired by my collegue which stated that:
<br>
> *"Creation of `List<T>` is expensive, you should __ALWAYS__ use `Collection<T>`"*  

So I decided to put it into test with excellent **BenchmarkDotNet** library.
<br><br>
* [List\<T\> vs Collection\<T\>](WhichShouldYouUse/Benchmarks/ListVsCollection/Results.md)  
* [Method group vs Lambda in loop](WhichShouldYouUse/Benchmarks/MethodGroupVsLambda/Results.md)

#####WIP:
* Custom "ToString()" for each `Enum` member: Custom Attribute vs `EnumMemberAttribute` vs Extension method.  
All with Enum <-> String conversion.

<br>
>  *"Premature optimization is the root of all evil"* -- Donald Knuth 
