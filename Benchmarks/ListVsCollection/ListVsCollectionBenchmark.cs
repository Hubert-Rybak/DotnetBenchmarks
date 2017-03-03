using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using DotnetBenchmarks.Seed;

namespace DotnetBenchmarks.Benchmarks.ListVsCollection
{
    [ClrJob, CoreJob]
    public class ListVsCollectionBenchmarks
    {
        private readonly Collection<ComplexObject> _collection;

        private readonly List<ComplexObject> _list;

        private readonly List<ComplexObject> _itemsToAdd;

        public ListVsCollectionBenchmarks()
        {
            _collection = new Collection<ComplexObject>(DataSeeder.GetManyComplexObjects());
            _list = new List<ComplexObject>(DataSeeder.GetManyComplexObjects());

            _itemsToAdd = DataSeeder.GetManyComplexObjects();
        }

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

        [Benchmark]
        public ComplexObject FindOnCollection()
        {
            return this._collection.SingleOrDefault(BenchmarkPredicate);
        }

        [Benchmark]
        public ComplexObject FindOnList()
        {
            return this._list.Find(BenchmarkPredicate);
        }

        private bool BenchmarkPredicate(ComplexObject complexObject)
        {
            return complexObject.Name == "Test4" && complexObject.Date == DateTime.Today;
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