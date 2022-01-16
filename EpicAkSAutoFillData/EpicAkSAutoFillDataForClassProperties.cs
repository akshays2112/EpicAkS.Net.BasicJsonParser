using System.Reflection;
using Bogus;

namespace EpicAkSAutoFillData
{
    public static class EpicAkSAutoFillDataForClassProperties
    {
        private enum EpicAkSBaseTypeNames
        {
            String, //string
            NullableString //string?
        }

        private static bool CompareInstancesOfAnArray(object? obj1, object? obj2)
        {
            Array? obj1Arr = obj1 as Array;
            Array? obj2Arr = obj2 as Array;
            if (obj1Arr is null || obj2Arr is null || obj1Arr.Length != obj2Arr.Length) return false;
            for (int i = 0; i < obj1Arr.Length; i++)
            {
                object? obj1ArrIValue = obj1Arr.GetValue(i);
                object? obj2ArrIValue = obj2Arr.GetValue(i);
                Type? obj1ArrIValueType = obj1ArrIValue?.GetType();
                Type? obj2ArrIValueType = obj2ArrIValue?.GetType();
                if (obj1ArrIValueType != obj2ArrIValueType) return false;
                if (obj1ArrIValueType?.IsArray == true && !CompareInstancesOfAnArray(obj1ArrIValue, obj2ArrIValue)) return false;
                else if (obj1ArrIValueType?.IsClass == true && obj1ArrIValueType.Name != "String" && !CompareInstancesOfAClass(obj1ArrIValue, obj2ArrIValue)) return false;
                else if (obj1ArrIValue != obj2ArrIValue && (obj1ArrIValue == null || !obj1ArrIValue.Equals(obj2ArrIValue))) return false;
            }
            return true;
        }

        public static bool CompareInstancesOfAClass(object? obj1, object? obj2)
        {
            if (obj1 is null || obj2 is null) return false;
            Type type = obj1.GetType();
            if(type != obj2.GetType()) return false;
            if (type.IsClass)
            {
                foreach (PropertyInfo pi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    object? obj1Value = pi.GetValue(obj1, null);
                    object? obj2Value = pi.GetValue(obj2, null);

                    if (obj1Value != obj2Value && (obj1Value == null || !obj1Value.Equals(obj2Value)))
                        if (pi.PropertyType.IsArray && !CompareInstancesOfAnArray(obj1Value, obj2Value))
                            if (pi.PropertyType.IsClass && !CompareInstancesOfAClass(obj1Value, obj2Value)) return false;
                }
                return true;
            }
            else if (type.IsArray) return CompareInstancesOfAnArray(obj1, obj2);
            return false;
        }

        private static string GenerateFakerString(bool isEmpty, Random? random = null) => 
            isEmpty && random?.Next(0, 1) == 0 ? string.Empty : new Faker().Person.FullName;

        private static object? GenerateFakerStringArray(bool doEmpty, int len, bool isEmpty = false)
        {
            if (doEmpty) return Array.Empty<string>();
            string[] stringArray = new string[len];
            for (int i = 0; i < len; i++) 
                stringArray[i] = GenerateFakerString(isEmpty);
            return stringArray;
        }

        private static object? GenerateFakerArray(bool isEmpty, EpicAkSBaseTypeNames baseTypeName, Random random)
        {
            bool doEmpty = isEmpty && random?.Next(0, 1) == 0;
            int len = random is null ? 2 : random.Next(2, 5);
            switch (baseTypeName)
            {
                case EpicAkSBaseTypeNames.String:
                    return GenerateFakerStringArray(doEmpty, len);
                case EpicAkSBaseTypeNames.NullableString:
                    return GenerateFakerStringArray(doEmpty, len, true);
                default:
                    return default;
            }
        }

        private static void SetDummyDataForProperty(object obj, PropertyInfo propertyInfo, Random random)
        {
            if (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(String)) 
                propertyInfo.SetValue(obj, GenerateFakerString(false));
            else if ((propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(String)) && propertyInfo.PropertyType == typeof(Nullable<>))
                propertyInfo.SetValue(obj, GenerateFakerString(true, random));
            else if (propertyInfo.PropertyType == typeof(string[]))
                propertyInfo.SetValue(obj, GenerateFakerArray(false, EpicAkSBaseTypeNames.String, random));
            else if (propertyInfo.PropertyType == typeof(string?[]))
                propertyInfo.SetValue(obj, GenerateFakerArray(false, EpicAkSBaseTypeNames.NullableString, random));
            else if (propertyInfo.PropertyType == typeof(string[]) && propertyInfo.PropertyType == typeof(Nullable<>))
                propertyInfo.SetValue(obj, GenerateFakerArray(true, EpicAkSBaseTypeNames.String, random));
            else if (propertyInfo.PropertyType == typeof(string?[]) && propertyInfo.PropertyType == typeof(Nullable<>))
                propertyInfo.SetValue(obj, GenerateFakerArray(true, EpicAkSBaseTypeNames.NullableString, random));
        }

        public static T? AutoFillDataForObject<T>(T? obj)
        {
            if (obj is null) return default;
            Type type = obj.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            Random random = new Random();
            foreach (PropertyInfo propertyInfo in propertyInfos)
                SetDummyDataForProperty(obj, propertyInfo, random);
            return obj;
        }
    }
}
