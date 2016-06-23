using System;
using BenchmarkDotNet.Running;

namespace WhichShouldYouUse
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Initialize>();
            BenchmarkRunner.Run<AddElements>();
            BenchmarkRunner.Run<FindElements>();

            Console.ReadKey();
        }
    }
}
