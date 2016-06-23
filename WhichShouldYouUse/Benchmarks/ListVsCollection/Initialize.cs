using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;
using WhichShouldYouUse.Models;

namespace WhichShouldYouUse.Benchmarks
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class Initialize : ConfigurationBase
    {
        [Benchmark]
        public Collection<ComplexObject> InitializeCollection()
        {
            return new Collection<ComplexObject>();
        }

        [Benchmark]
        public List<ComplexObject> InitializeList()
        {
            return new List<ComplexObject>();
        }
    }
}