using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Configs;

namespace WhichShouldYouUse.Benchmarks.Enums.EnumToString
{
    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class EnumToStringBenchmark : ConfigurationBase
    {
        [Benchmark]
        public TestEnumWithAttributes EnumToStringWithCustomAttribute()
        {
            var enumString = TestEnumWithAttributes.Value2.ToEnumString();
            var testEnumWithAttributes = enumString.ToEnum<TestEnumWithAttributes>();

            return testEnumWithAttributes;
        }

        [Benchmark]
        public TestEnumWithAttributes EnumToStringWithCustomAttributeWithCache()
        {
            var enumString = TestEnumWithAttributes.Value2.ToEnumStringWithCache();
            var testEnumWithAttributes = enumString.ToEnumWithCache<TestEnumWithAttributes>();

            return testEnumWithAttributes;
        }

        [Benchmark]
        public TestEnumWithoutAttributes EnumToStringWithDictionary()
        {
            var s = TestEnumWithoutAttributes.Value2.ToEnumStringWithDict(Dictionaries.TestEnumValues);
            var testEnumWithoutAttributes = s.ToEnumWithDict(Dictionaries.TestEnumValues);

            return testEnumWithoutAttributes;
        }
    }
}