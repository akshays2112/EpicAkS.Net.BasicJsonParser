using System.Reflection;

namespace EpicAkS.Net.BasicJsonParser
{
    internal static class Helpers
    {
        internal enum JsonType
        {
            String,
            Integer,
            Double,
            Number,
            Boolean,
            Byte,
            Char,
            Class,
            StringArray,
            IntegerArray,
            DoubleArray,
            NumberArray,
            BooleanArray,
            ByteArray,
            CharArray,
            ClassArray,
            Other
        }

        internal struct TypePropertyNameAlias
        {
            internal string Name { get; set; }
            internal string Alias { get; set; }
            internal PropertyInfo PropertyInfo { get; set; }
            internal JsonType JsonType { get; set; }

            internal TypePropertyNameAlias(string name, string alias, PropertyInfo propertyInfo, JsonType jsonType)
            {
                Name = name;
                Alias = alias;
                PropertyInfo = propertyInfo;
                JsonType = jsonType;
            }
        }

        internal struct ClassHavingTypePropertyNameAliases
        {
            internal Type Type { get; set; }
            internal TypePropertyNameAlias[] PropertyNameAliases { get; set; }

            internal ClassHavingTypePropertyNameAliases(Type type, TypePropertyNameAlias[] propertyNameAliases)
            {
                Type = type;
                PropertyNameAliases = propertyNameAliases;
            }
        }

        internal static ClassHavingTypePropertyNameAliases[] ClassesHavingTypePropertyNameAliases { get; } = GetAllClasses();

        internal static JsonType GetJsonType(PropertyInfo propertyInfo)
        {
            Type propertyType = propertyInfo.PropertyType;
            if (propertyType == typeof(string) || propertyType == typeof(String))
                return JsonType.String;
            if (propertyType == typeof(bool) || propertyType == typeof(Boolean) ||
                propertyType == typeof(bool?) || propertyType == typeof(Boolean?))
                return JsonType.Boolean;
            if (propertyType == typeof(int) || propertyType == typeof(Int16) ||
                propertyType == typeof(Int32) || propertyType == typeof(Int64) ||
                propertyType == typeof(IntPtr) ||
                propertyType == typeof(uint) || propertyType == typeof(UInt16) ||
                propertyType == typeof(UInt32) || propertyType == typeof(UInt64) ||
                propertyType == typeof(UIntPtr) ||
                propertyType == typeof(int?) || propertyType == typeof(Int16?) ||
                propertyType == typeof(Int32?) || propertyType == typeof(Int64?) ||
                propertyType == typeof(IntPtr?) ||
                propertyType == typeof(uint?) || propertyType == typeof(UInt16?) ||
                propertyType == typeof(UInt32?) || propertyType == typeof(UInt64?) ||
                propertyType == typeof(UIntPtr?))
                return JsonType.Integer;
            if (propertyType == typeof(double) || propertyType == typeof(Double) ||
                propertyType == typeof(double?) || propertyType == typeof(Double?))
                return JsonType.Double;
            if (propertyType == typeof(float) || propertyType == typeof(long) ||
                propertyType == typeof(ulong) || propertyType == typeof(decimal) ||
                propertyType == typeof(Decimal) ||
                propertyType == typeof(float?) || propertyType == typeof(long?) ||
                propertyType == typeof(ulong?) || propertyType == typeof(decimal?) ||
                propertyType == typeof(Decimal?))
                return JsonType.Number;
            if (propertyType == typeof(byte) || propertyType == typeof(Byte) ||
                propertyType == typeof(byte?) || propertyType == typeof(Byte?))
                return JsonType.Byte;
            if (propertyType == typeof(char) || propertyType == typeof(Char) ||
                propertyType == typeof(char?) || propertyType == typeof(Char?))
                return JsonType.Char;

            if (propertyType == typeof(string[]) || propertyType == typeof(String[]))
                return JsonType.StringArray;
            if (propertyType == typeof(bool[]) || propertyType == typeof(Boolean[]))
                return JsonType.BooleanArray;
            if (propertyType == typeof(int[]) || propertyType == typeof(Int16[]) ||
                propertyType == typeof(Int32[]) || propertyType == typeof(Int64[]) ||
                propertyType == typeof(IntPtr[]) ||
                propertyType == typeof(uint[]) || propertyType == typeof(UInt16[]) ||
                propertyType == typeof(UInt32[]) || propertyType == typeof(UInt64[]) ||
                propertyType == typeof(UIntPtr[]))
                return JsonType.IntegerArray;
            if (propertyType == typeof(double[]) || propertyType == typeof(Double[]))
                return JsonType.DoubleArray;
            if (propertyType == typeof(float[]) || propertyType == typeof(long[]) ||
                propertyType == typeof(ulong[]) || propertyType == typeof(decimal[]) ||
                propertyType == typeof(Decimal[]))
                return JsonType.NumberArray;
            if (propertyType == typeof(byte[]) || propertyType == typeof(Byte[]))
                return JsonType.ByteArray;
            if ((propertyType == typeof(char[]) || propertyType == typeof(Char[])))
                return JsonType.CharArray;

            if (propertyType.IsClass)
            {
                if (propertyType.IsArray)
                {
                    return JsonType.ClassArray;
                }
                else
                {
                    return JsonType.Class;
                }
            }

            return JsonType.Other;
        }

        internal static TypePropertyNameAlias[] GetPropertyNameAliases(Type type)
        {
            List<TypePropertyNameAlias> typePropertyNameAliases = new();

            foreach (PropertyInfo typePropertyInfo in type.GetProperties())
            {
                bool found = false;
                JsonType jsonType = GetJsonType(typePropertyInfo);
                foreach (Attribute propertyNameAlias in typePropertyInfo.GetCustomAttributes())
                {
                    EpicAkSSkipPropertyAttribute? skipPropertyAttribute = propertyNameAlias as EpicAkSSkipPropertyAttribute;
                    if (skipPropertyAttribute is not null)
                    {
                        found = true;
                        continue;
                    }
                    EpicAkSPropertyNameAliasAttribute? propertyNameAliasAttribute = propertyNameAlias as EpicAkSPropertyNameAliasAttribute;
                    if (propertyNameAliasAttribute is not null)
                    {
                        typePropertyNameAliases.Add(new(typePropertyInfo.Name, propertyNameAliasAttribute.Alias, typePropertyInfo, jsonType));
                        found = true;
                        continue;
                    }
                }
                if (!found)
                    typePropertyNameAliases.Add(new(typePropertyInfo.Name, typePropertyInfo.Name, typePropertyInfo, jsonType));
            }

            return typePropertyNameAliases.ToArray();
        }

        internal static ClassHavingTypePropertyNameAliases[] GetAllClasses()
        {
            List<ClassHavingTypePropertyNameAliases> classesHavingTypePropertyNameAliases = new();
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if (!string.IsNullOrWhiteSpace(type.FullName) && (string.IsNullOrWhiteSpace(JsonHelpers.NamespaceScoped) || 
                    (!string.IsNullOrWhiteSpace(JsonHelpers.NamespaceScoped) && type.FullName.StartsWith(JsonHelpers.NamespaceScoped))))
                {
                    classesHavingTypePropertyNameAliases.Add(new ClassHavingTypePropertyNameAliases(type, GetPropertyNameAliases(type)));
                }
            }
            return classesHavingTypePropertyNameAliases.ToArray();
        }
    }
}
