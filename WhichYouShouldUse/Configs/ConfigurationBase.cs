using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;

namespace WhichYouShouldUse.Configs
{
    public class ConfigurationBase
    {
        protected class MemoryAllocationConfig : ManualConfig
        {
            public MemoryAllocationConfig()
            {
                Add(StatisticColumn.AllStatistics);
                Add(new MemoryDiagnoser());
                Add(Job.Dry);
                Add(Job.AllJits);
            }
        }
    }
}