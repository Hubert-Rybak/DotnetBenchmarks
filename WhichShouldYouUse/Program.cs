using System;
using BenchmarkDotNet.Running;
using WhichShouldYouUse.Benchmarks;
using WhichShouldYouUse.Benchmarks.Enums.EnumToString;
using WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular;
using WhichShouldYouUse.Benchmarks.MethodGroupVsLambda;

namespace WhichShouldYouUse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<T> vs Collection<T>
            //BenchmarkRunner.Run<BenchmarkListVsCollectionInitialize>();
            //BenchmarkRunner.Run<BenchmarkListVsCollectionAddAndRemoveElements>();
            //BenchmarkRunner.Run<BenchmarkListVsCollectionFindElements>();

            //Method group vs lambda in loop
            //BenchmarkRunner.Run<BenchmarkMehodGroupVsLambda>();

            //Enums
            //BenchmarkRunner.Run<EnumToStringBenchmark>();
            BenchmarkRunner.Run<BenchmarkObjectEnumVsRegular>();
        }
    }
}