﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

using BenchmarkDotNet.Attributes;

using WhichYouShouldUse.Configs;
using WhichYouShouldUse.Models;

namespace WhichYouShouldUse
{
    [Config(typeof(MemoryAllocationConfig))]
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