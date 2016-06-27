using BenchmarkDotNet.Attributes;
using WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular.ObjectEnum;
using WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular.Regular;
using WhichShouldYouUse.Configs;

namespace WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular
{

    [Config(typeof(DefaultJobWithMemoryAllocation))]
    public class BenchmarkObjectEnumVsRegular : ConfigurationBase
    {

        [Benchmark]
        public StreetType CreateObjectEnum()
        {
            var streetTypeObject = ObjectEnum.ObjectEnum.ToObject<StreetType>(1);
            return streetTypeObject;
        }

        [Benchmark]
        public Location CreateRegularEnum()
        {
            var location = new Location()
            {
                StreetTypes = StreetTypes.Avenue
            };

            return location;
        }
    }
}