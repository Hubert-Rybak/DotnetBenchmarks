using System;
using BenchmarkDotNet.Running;
using WhichShouldYouUse.Benchmarks;
using WhichShouldYouUse.Benchmarks.MethodGroupVsLambda;

namespace WhichShouldYouUse
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<T> vs Collection<T>
            //BenchmarkRunner.Run<Initialize>();
            BenchmarkRunner.Run<AddAndRemoveElements>();
            //BenchmarkRunner.Run<FindElements>();

            //Method group vs lambda in loop
            //BenchmarkRunner.Run<MethodGroupVsLambdaInLoop>();

            Console.ReadKey();
        }
    }
}
