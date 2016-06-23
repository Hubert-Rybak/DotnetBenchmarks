using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;
using WhichShouldYouUse.Models;

namespace WhichShouldYouUse.Benchmarks
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class FindElements : ConfigurationBase
    {
        private readonly Collection<ComplexObject> collection;

        private readonly List<ComplexObject> list;

        public FindElements()
        {
            this.collection = new Collection<ComplexObject>(DataSeeder.GetManyComplexObjects());
            this.list = new List<ComplexObject>(DataSeeder.GetManyComplexObjects());
        }

        [Benchmark]
        public ComplexObject FindOnCollection()
        {
            return this.collection.SingleOrDefault(BenchmarkPredicate);
        }

        [Benchmark]
        public ComplexObject FindOnList()
        {
            return this.list.Find(BenchmarkPredicate);
        }

        private bool BenchmarkPredicate(ComplexObject complexObject)
        {
            return complexObject.Name == "Test4" && complexObject.Date == DateTime.Today;
        }
    }
}