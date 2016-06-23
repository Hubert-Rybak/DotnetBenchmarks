﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;

namespace WhichShouldYouUse.Configs
{
    public class ConfigurationBase
    {
        protected class MemoryAllocationConfig : ManualConfig
        {
            public MemoryAllocationConfig()
            {
                Add(new MemoryDiagnoser());
                Add(Job.Dry);
                Add(Job.AllJits);
            }
        }
    }
}