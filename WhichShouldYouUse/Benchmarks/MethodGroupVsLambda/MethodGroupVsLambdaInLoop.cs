using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;

namespace WhichShouldYouUse.Benchmarks.MethodGroupVsLambda
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class MethodGroupVsLambdaInLoop : ConfigurationBase
    {
        private int _maxCalls= 5;

        [Benchmark]
        public void MethodGroupInLoop()
        {
            for (int i = 0; i < _maxCalls; i++)
            {
                Call(Dump);
            }
        }

        [Benchmark]
        public void LambdaInLoop()
        {
            for (int i = 0; i < _maxCalls; i++)
            {
                Call(s => Dump(s));
            }
        }

        private static void Call(Action<string> act)
        {
            act("Hi!");
        }

        private static void Dump(string str)
        {

        }
    }
}