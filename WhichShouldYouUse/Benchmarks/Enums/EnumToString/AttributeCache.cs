using System;
using System.Collections.Generic;
using System.Reflection;

namespace WhichShouldYouUse.Benchmarks.Enums.EnumToString
{
    public class AttributeCache
    {
        private static Dictionary<string, FieldInfo> FieldCacheDict = new Dictionary<string, FieldInfo>();

        private static Dictionary<FieldInfo, Object[]> AttributeCacheDict = new Dictionary<FieldInfo, Object[]>();

        public static T[] GetCustomAttributes<T>(Type @type, string name)
        {
            FieldInfo fieldInfoFromCache = GetFieldInfoFromCache(type, name);
            object[] attributesFromCache = GetAttributesFromCache(fieldInfoFromCache, typeof(T));
            return attributesFromCache as T[];
        }

        private static object[] GetAttributesFromCache(FieldInfo fieldInfoFromCache, Type type)
        {
            object[] attributes;
            if (AttributeCacheDict.TryGetValue(fieldInfoFromCache, out attributes))
            {
                return attributes;
            }

            var customAttributes = fieldInfoFromCache.GetCustomAttributes(type, true);
            AttributeCacheDict.Add(fieldInfoFromCache, customAttributes);
            return customAttributes;
        }

        private static FieldInfo GetFieldInfoFromCache(Type type, string name)
        {
            FieldInfo result;
            if (FieldCacheDict.TryGetValue(name, out result))
            {
                return result;
            }

            var fieldInfo = type.GetField(name);
            FieldCacheDict.Add(name, fieldInfo);

            return fieldInfo;
        }
    }
}