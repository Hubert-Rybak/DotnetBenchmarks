using System;
using BenchmarkDotNet.Running;
using DotnetBenchmarks.Benchmarks.ListVsCollection;
using DotnetBenchmarks.Benchmarks.MethodGroupVsLambda;

namespace DotnetBenchmarksCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> vs Collection<T>
            BenchmarkRunner.Run<ListVsCollectionBenchmarks>();

            //Method group vs lambda in loop
            BenchmarkRunner.Run<BenchmarkMehodGroupVsLambda>();            
        }
    }
}
