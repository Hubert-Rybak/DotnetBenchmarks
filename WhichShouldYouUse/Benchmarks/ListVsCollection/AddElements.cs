using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;
using WhichShouldYouUse.Models;

namespace WhichShouldYouUse.Benchmarks
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class AddElements : ConfigurationBase
    {
        private Collection<ComplexObject> collection;

        private List<ComplexObject> list;

        private List<ComplexObject> itemsToAdd;

        public AddElements()
        {
            this.collection = new Collection<ComplexObject>();
            this.list = new List<ComplexObject>();
            this.itemsToAdd = DataSeeder.GetManyComplexObjects();
        }

        [Benchmark]
        public Collection<ComplexObject> TestAddCollection()
        {
            foreach (ComplexObject complexObject in this.itemsToAdd)
            {
                this.collection.Add(complexObject);
            }

            return this.collection;
        }

        [Benchmark]
        public List<ComplexObject> TestAddList()
        {
            foreach (ComplexObject complexObject in this.itemsToAdd)
            {
                this.list.Add(complexObject);
            }

            return this.list;
        }
    }
}