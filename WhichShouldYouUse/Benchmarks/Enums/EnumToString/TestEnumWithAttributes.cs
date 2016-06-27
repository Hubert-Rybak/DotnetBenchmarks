using System.ComponentModel;

namespace WhichShouldYouUse.Benchmarks.Enums.EnumToString
{
    public enum TestEnumWithAttributes
    {
        [Description("This is description of value 0!")]
        Value0,
        [Description("This is description of value 1!")]
        Value1,
        [Description("This is description of value 2!")]
        Value2,
        [Description("This is description of value 3!")]
        Value3,
    }
}