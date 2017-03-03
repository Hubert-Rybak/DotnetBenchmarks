using System;
using BenchmarkDotNet.Attributes;

namespace DotnetBenchmarks.Benchmarks.MethodGroupVsLambda
{
    public class BenchmarkMehodGroupVsLambda
    {
        private int _maxCalls= 5;

        [Benchmark]
        public void MethodGroupInLoop()
        {
            for (int i = 0; i < _maxCalls; i++)
            {
                Call(EmptyFunction);
            }
        }

        [Benchmark]
        public void LambdaInLoop()
        {
            for (int i = 0; i < _maxCalls; i++)
            {
                Call(s => EmptyFunction(s));
            }
        }

        private static void Call(Action<string> act)
        {
            act("Hi!");
        }

        private static void EmptyFunction(string str)
        {

        }
    }
}