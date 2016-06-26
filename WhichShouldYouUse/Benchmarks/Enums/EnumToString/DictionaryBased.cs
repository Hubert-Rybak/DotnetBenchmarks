using System;
using System.Collections.Generic;
using System.Linq;

namespace WhichShouldYouUse.Benchmarks.Enums.EnumToString
{
    public static class Dictionaries
    {
        public static Dictionary<TestEnumWithoutAttributes, string> TestEnumValues = new Dictionary<TestEnumWithoutAttributes, string>
        {
            {TestEnumWithoutAttributes.Value0, "This is description of value 0!"},
            {TestEnumWithoutAttributes.Value1, "This is description of value 1!"},
            {TestEnumWithoutAttributes.Value2, "This is description of value 2!"},
            {TestEnumWithoutAttributes.Value3, "This is description of value 3!"}
        };
    }

    public static class DictionaryBased
    {
        /// <exception cref="SystemException">
        ///     Throws if <paramref name="value" /> is not found in in <paramref name="dictionary" />
        /// </exception>
        public static string ToEnumStringWithDict<T>(this T value, Dictionary<T, string> dictionary)
            where T : struct, IComparable, IFormattable, IConvertible
        {
            string resultString;
            if (dictionary.TryGetValue(value, out resultString))
            {
                return resultString;
            }

            throw new SystemException($"Value for {value} doesn't exist in provided dictionary!");
        }

        public static T ToEnumWithDict<T>(this string value, Dictionary<T, string> dictionary)
    where T : struct, IComparable, IFormattable, IConvertible
        {
            KeyValuePair<T, string> firstOrDefault = dictionary.FirstOrDefault(x => x.Value.Equals(value));
            if (firstOrDefault.Value != null)
            {
                return firstOrDefault.Key;
            }

            throw new SystemException($"Value for {value} doesn't exist in provided dictionary!");
        }
    }
}