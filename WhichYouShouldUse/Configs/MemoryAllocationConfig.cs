using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;

namespace WhichYouShouldUse.Configs
{
    public class MemoryAllocationConfig : ManualConfig
    {
        public MemoryAllocationConfig()
        {
            //Add(StatisticColumn.AllStatistics);
            //Add(new MemoryDiagnoser());
            //Add(Job.Default.With(Framework.V40));
            //Add(Job.Default.With(Framework.V45));
            //Add(Job.Default.With(Framework.V452));
            //Add(Job.Default.With(Framework.V46));
            //Add(Job.Default.With(Framework.V462));



        }
    }
}