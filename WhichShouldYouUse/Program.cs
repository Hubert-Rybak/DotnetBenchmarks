using System;
using BenchmarkDotNet.Running;
using WhichShouldYouUse.Benchmarks;
using WhichShouldYouUse.Benchmarks.Enums;
using WhichShouldYouUse.Benchmarks.Enums.EnumToString;
using WhichShouldYouUse.Benchmarks.MethodGroupVsLambda;

namespace WhichShouldYouUse
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<T> vs Collection<T>
            //BenchmarkRunner.Run<Initialize>();
            //BenchmarkRunner.Run<AddAndRemoveElements>();
            //BenchmarkRunner.Run<FindElements>();

            //Method group vs lambda in loop
            //BenchmarkRunner.Run<MethodGroupVsLambdaInLoop>();

            BenchmarkRunner.Run<EnumBenchmark>();

            Console.ReadKey();
        }
    }
}
