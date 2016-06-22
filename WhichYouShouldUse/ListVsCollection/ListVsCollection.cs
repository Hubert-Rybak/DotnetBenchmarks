using System.Collections.Generic;
using System.Collections.ObjectModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using WhichYouShouldUse.Models;

namespace WhichYouShouldUse
{
    [Config(typeof(MemoryAllocationConfig))]
    public class ListVsCollection
    {
        private class MemoryAllocationConfig : ManualConfig
        {
            public MemoryAllocationConfig()
            {
                Add(StatisticColumn.AllStatistics);
                //Add(RPlotExporter.Default);
                //Add(CsvMeasurementsExporter.Default);
                Add(new MemoryDiagnoser());
                //Add(Job.Default.With(Framework.V40));
                Add(Job.Default.With(Framework.V462).With(Runtime.Clr).With(Platform.X64));
                Add(Job.Default.With(Framework.V452).With(Runtime.Clr).With(Platform.X64));
                Add(Job.Default.With(Framework.V40).With(Runtime.Clr).With(Platform.X64));

                Add(Job.Dry);
                Add(Job.AllJits);
                //Add(Job.Default.With(Framework.V452));
                //Add(Job.Default.With(Framework.V46));
                //Add(Job.Default.With(Framework.V462));
            }
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
    }
}