using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;
using WhichShouldYouUse.Models;

namespace WhichShouldYouUse.Benchmarks
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class AddAndRemoveElements : ConfigurationBase
    {
        private readonly Collection<ComplexObject> _collection;

        private readonly List<ComplexObject> _itemsToAdd;

        private readonly List<ComplexObject> _list;

        public AddAndRemoveElements()
        {
            _collection = new Collection<ComplexObject>();
            _list = new List<ComplexObject>();
            _itemsToAdd = DataSeeder.GetManyComplexObjects();
        }

        [Benchmark]
        public Collection<ComplexObject> AddAndRemoveFromCollection()
        {
            foreach (var complexObject in _itemsToAdd)
            {
                _collection.Add(complexObject);
            }

            var collectionSize = _collection.Count;
            for (var i = 0; i < collectionSize; i++)
            {
                _collection.RemoveAt(0);
            }

            return _collection;
        }

        [Benchmark]
        public List<ComplexObject> AddAndRemoveFromList()
        {
            foreach (var complexObject in _itemsToAdd)
            {
                _list.Add(complexObject);
            }

            var collectionSize = _list.Count;
            for (var i = 0; i < collectionSize; i++)
            {
                _list.RemoveAt(0);
            }

            return _list;
        }
    }
}