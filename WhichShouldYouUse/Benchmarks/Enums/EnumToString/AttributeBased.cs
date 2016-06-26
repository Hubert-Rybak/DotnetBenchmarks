using System;
using System.ComponentModel;
using System.Linq;

namespace WhichShouldYouUse.Benchmarks.Enums.EnumToString
{
    public static class AttributeBased
    {
        public static string ToEnumString<T>(this T type) where T : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Must be enum type", nameof(type));
            }
            var name = Enum.GetName(enumType, type);

            var enumMemberAttribute =
                ((DescriptionAttribute[]) enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), true))
                    .SingleOrDefault();
            return enumMemberAttribute != null ? enumMemberAttribute.Description : name;
        }

        public static string ToEnumStringWithCache<T>(this T type) where T : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Must be enum type", nameof(type));
            }
            var name = Enum.GetName(enumType, type);

            var enumMemberAttribute = AttributeCache.GetCustomAttributes<DescriptionAttribute>(enumType, name).FirstOrDefault();
            return enumMemberAttribute != null ? enumMemberAttribute.Description : name;
        }

        public static T ToEnum<T>(this string str) where T : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Must be enum type", "type");
            }
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute =
                    ((DescriptionAttribute[])
                        enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), true)).SingleOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Description == str)
                {
                    return (T) Enum.Parse(enumType, name);
                }
                if (name == str)
                {
                    return (T) Enum.Parse(enumType, name);
                }
            }

            throw new InvalidCastException($"Impossible to cast {str} to {typeof(T).Name}");
        }

        public static T ToEnumWithCache<T>(this string str) where T : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Must be enum type", "type");
            }
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute = AttributeCache.GetCustomAttributes<DescriptionAttribute>(enumType, name).FirstOrDefault();

                if (enumMemberAttribute != null && enumMemberAttribute.Description == str)
                {
                    return (T)Enum.Parse(enumType, name);
                }
                if (name == str)
                {
                    return (T)Enum.Parse(enumType, name);
                }
            }

            throw new InvalidCastException($"Impossible to cast {str} to {typeof(T).Name}");
        }
    }
}

