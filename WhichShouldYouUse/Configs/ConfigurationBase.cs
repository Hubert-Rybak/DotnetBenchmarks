using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;

namespace WhichShouldYouUse.Configs
{
    public class ConfigurationBase
    {
        protected class DefaultJobWithMemoryAllocation : ManualConfig
        {
            public DefaultJobWithMemoryAllocation()
            {
                Add(new MemoryDiagnoser());
                Add(Job.Default);
                //Add(Job.AllJits);
            }
        }
    }
}