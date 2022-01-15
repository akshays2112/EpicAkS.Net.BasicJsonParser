﻿using System.Text;
using System.Reflection;

namespace EpicAkS.Net.BasicJsonParser
{
    /// <summary>
    /// <c>JsonHelpers</c> Used to skip a property for json purposes.
    /// </summary>
    public static class JsonHelpers
    {
        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public static string NamespaceScoped { get; set; } = "EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.";
        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public static bool NoWhitespace { get; set; } = true;

        private class JsonArrayItem
        {
            internal string? Value { get; set; }
            internal List<JsonArrayItem>? JsonArrayItems { get; set; }
            internal JsonObject? JsonObjectValue { get; set; }
            internal JsonArrayItem? ParentJsonArrayItem { get; set; }
            internal JsonProperty? ParentJsonProperty { get; set; }
        }

        private class JsonProperty
        {
            internal string? Name { get; set; }
            internal string? Value { get; set; }
            internal List<JsonArrayItem>? JsonArrayItems { get; set; }
            internal JsonObject? JsonObjectValue { get; set; }
            internal JsonObject? ParentJsonObject { get; set; }
        }

        private class JsonObject
        {
            internal List<JsonProperty> JsonProperties { get; set; } = new();
            internal JsonProperty? ParentJsonProperty { get; set; } = null;
            internal JsonArrayItem? ParentJsonArrayItem { get; set; }
        }

        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public static void Initialize()
        {
            _ = Serialize(new WebAPIClasses.ServiceProviders.JsonHelpersInitializeEmptyClass.EmptyClass());
        }

        private static void SetPropertyValue(object obj, PropertyInfo propertyInfo, JsonProperty jsonProperty)
        {
            Type propertyType = propertyInfo.PropertyType;
            if (propertyType == typeof(string) || propertyType == typeof(String))
            {
                propertyInfo.SetValue(obj, jsonProperty.Value);
            }
            else if (propertyType == typeof(bool) || propertyType == typeof(bool?))
            {
                propertyInfo.SetValue(obj, bool.Parse(jsonProperty.Value ?? string.Empty));
            }
            else if (propertyType == typeof(Boolean) || propertyType == typeof(Boolean?))
            {
                propertyInfo.SetValue(obj, Boolean.Parse(jsonProperty.Value ?? string.Empty));
            }
            else if (propertyType == typeof(int) || propertyType == typeof(int?))
            {
                propertyInfo.SetValue(obj, int.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Int16) || propertyType == typeof(Int16?))
            {
                propertyInfo.SetValue(obj, Int16.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Int32) || propertyType == typeof(Int32?))
            {
                propertyInfo.SetValue(obj, Int32.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Int64) || propertyType == typeof(Int64?))
            {
                propertyInfo.SetValue(obj, Int64.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(IntPtr) || propertyType == typeof(IntPtr?))
            {
                propertyInfo.SetValue(obj, IntPtr.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(uint) || propertyType == typeof(uint?))
            {
                propertyInfo.SetValue(obj, uint.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(UInt16) || propertyType == typeof(UInt16?))
            {
                propertyInfo.SetValue(obj, UInt16.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(UInt32) || propertyType == typeof(UInt32?))
            {
                propertyInfo.SetValue(obj, UInt32.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(UInt64) || propertyType == typeof(UInt64?))
            {
                propertyInfo.SetValue(obj, UInt64.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(UIntPtr) || propertyType == typeof(UIntPtr?))
            {
                propertyInfo.SetValue(obj, UIntPtr.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(UInt64) || propertyType == typeof(UInt64?))
            {
                propertyInfo.SetValue(obj, UInt64.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(double) || propertyType == typeof(double?))
            {
                propertyInfo.SetValue(obj, double.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Double) || propertyType == typeof(Double?))
            {
                propertyInfo.SetValue(obj, Double.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(float) || propertyType == typeof(float?))
            {
                propertyInfo.SetValue(obj, float.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(long) || propertyType == typeof(long?))
            {
                propertyInfo.SetValue(obj, long.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(ulong) || propertyType == typeof(ulong?))
            {
                propertyInfo.SetValue(obj, ulong.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(decimal) || propertyType == typeof(decimal?))
            {
                propertyInfo.SetValue(obj, decimal.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Decimal) || propertyType == typeof(Decimal?))
            {
                propertyInfo.SetValue(obj, Decimal.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(byte) || propertyType == typeof(byte?))
            {
                propertyInfo.SetValue(obj, Convert.FromBase64String(jsonProperty?.Value ?? String.Empty)?.FirstOrDefault());
                //propertyInfo.SetValue(obj, byte.Parse(jsonProperty?.Value ?? String.Empty, System.Globalization.NumberStyles.HexNumber));
            }
            else if (propertyType == typeof(Byte) || propertyType == typeof(Byte?))
            {
                propertyInfo.SetValue(obj, Byte.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(char) || propertyType == typeof(char?))
            {
                propertyInfo.SetValue(obj, char.Parse(jsonProperty?.Value ?? String.Empty));
            }
            else if (propertyType == typeof(Char) || propertyType == typeof(Char?))
            {
                propertyInfo.SetValue(obj, Char.Parse(jsonProperty?.Value ?? String.Empty));
            }
        }

        private static void FillObjectWithValuesFromJsonObject(object obj, JsonObject? jsonObject)
        {
            if (jsonObject is not null && jsonObject.JsonProperties != null && jsonObject.JsonProperties.Count > 0)
            {
                Type type = obj.GetType();
                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    bool found = false;
                    foreach (Attribute attribute in propertyInfo.GetCustomAttributes())
                    {
                        if (attribute is EpicAkSSkipPropertyAttribute skipProperty)
                        {
                            found = true;
                            break;
                        }
                        if (attribute is EpicAkSPropertyNameAliasAttribute propertyNameAlias)
                        {
                            foreach (JsonProperty jsonProperty in jsonObject.JsonProperties)
                            {
                                if (jsonProperty.Name == propertyNameAlias.Alias)
                                {
                                    found = true;
                                    if (!string.IsNullOrWhiteSpace(jsonProperty.Value))
                                    {
                                        SetPropertyValue(obj, propertyInfo, jsonProperty);
                                    }
                                    else if (jsonProperty.JsonObjectValue is not null)
                                    {
                                        if (propertyInfo.GetValue(obj) is object objPropValue)
                                            FillObjectWithValuesFromJsonObject(objPropValue, jsonProperty.JsonObjectValue);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (!found)
                    {
                        foreach (JsonProperty jsonProperty in jsonObject.JsonProperties)
                        {
                            if (jsonProperty.Name == propertyInfo.Name)
                            {
                                if (!string.IsNullOrWhiteSpace(jsonProperty.Value))
                                {
                                    SetPropertyValue(obj, propertyInfo, jsonProperty);
                                }
                                break;
                            }
                            else if (jsonProperty.JsonObjectValue is not null)
                            {
                                if (propertyInfo.GetValue(obj) is object objPropValue)
                                    FillObjectWithValuesFromJsonObject(objPropValue, jsonProperty.JsonObjectValue);
                            }
                        }
                    }
                }
            }
        }

        private static void ParseJsonArray(char[] jsonChars, JsonArrayItem? parentJsonArrayItem, JsonProperty? parentJsonProperty)
        {
            JsonArrayItem? jsonArrayItem = new();
            if (parentJsonProperty is not null && parentJsonArrayItem is null)
            {
                parentJsonProperty.JsonArrayItems = new();
                jsonArrayItem.ParentJsonProperty = parentJsonProperty;
            }
            else if(parentJsonArrayItem is not null)
            {
                parentJsonArrayItem.JsonArrayItems = new();
                jsonArrayItem.ParentJsonArrayItem = parentJsonArrayItem;
            }
            else
            {
                return;
            }
            bool insideDoubleQuotes = false;
            bool encounteredBackslash = false;
            int arrayLevel = 0;
            List<char> buffer = new();

            for (int i = 0; i < jsonChars.Length; i++)
            {
                switch (jsonChars[i])
                {
                    case '{':
                        buffer.Add(jsonChars[i]);
                        break;
                    case '}':
                        buffer.Add(jsonChars[i]);
                        if (jsonArrayItem is not null)
                        {
                            (jsonArrayItem.JsonObjectValue, _) = ParseJson(buffer.ToArray(), 0, null);
                            if (jsonArrayItem.JsonObjectValue is not null)
                            {
                                jsonArrayItem.JsonObjectValue.ParentJsonArrayItem = jsonArrayItem;
                            }
                        }
                        buffer.Clear();
                        break;
                    case '[':
                        arrayLevel++;
                        buffer.Add(jsonChars[++i]);
                        break;
                    case ']':
                        arrayLevel--;
                        if (arrayLevel == 0 && parentJsonArrayItem is not null)
                        {
                            ParseJsonArray(buffer.ToArray(), jsonArrayItem, null);
                        }
                        buffer.Clear();
                        break;
                    case '"':
                        if (insideDoubleQuotes)
                        {
                            if (encounteredBackslash)
                            {
                                buffer.Add(jsonChars[i]);
                            }
                            else if(jsonArrayItem is not null)
                            {
                                jsonArrayItem.Value = new(buffer.ToArray());
                                buffer.Clear();
                                insideDoubleQuotes = false;
                            }
                        }
                        else
                        {
                            insideDoubleQuotes = true;
                        }
                        break;
                    case '\\':
                        if (encounteredBackslash)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        encounteredBackslash = !encounteredBackslash;
                        break;
                    case ',':
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        else
                        {
                            JsonArrayItem? newJsonArrayItem = new();
                            if (parentJsonProperty is not null && parentJsonArrayItem is null && jsonArrayItem is not null)
                            {
                                parentJsonProperty.JsonArrayItems?.Add(jsonArrayItem);
                                newJsonArrayItem.ParentJsonProperty = parentJsonProperty;
                            }
                            else if (parentJsonArrayItem is not null && jsonArrayItem is not null)
                            {
                                parentJsonArrayItem.JsonArrayItems?.Add(jsonArrayItem);
                                newJsonArrayItem.ParentJsonArrayItem = parentJsonArrayItem;
                            }
                            jsonArrayItem = newJsonArrayItem;
                        }
                        break;
                    default:
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        break;
                }
            }
        }

        private static (JsonObject? jsonObject, int pos) ParseJson(char[] jsonChars, int pos, JsonProperty? parentJsonProperty)
        {
            JsonObject? jsonObject = new();
            JsonObject? currentJsonObject = jsonObject;
            if (parentJsonProperty is not null)
                currentJsonObject.ParentJsonProperty = parentJsonProperty;
            JsonProperty? currentJsonProperty = new();
            currentJsonProperty.ParentJsonObject = currentJsonObject;
            currentJsonObject.JsonProperties.Add(currentJsonProperty);
            bool insideDoubleQuotes = false;
            bool encounteredBackslash = false;
            bool encounteredColon = false;
            List<char> buffer = new();

            for (int i = pos; i < jsonChars.Length; i++)
            {
                switch (jsonChars[i])
                {
                    case '{':
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        else if (encounteredColon && currentJsonProperty is not null)
                        {
                            (currentJsonProperty.JsonObjectValue, i) = ParseJson(jsonChars, i + 1, currentJsonProperty);
                        }
                        break;
                    case '}':
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        else
                        {
                            return (jsonObject, pos);
                        }
                        break;
                    case '[':
                        buffer.Add(jsonChars[++i]);
                        break;
                    case ']':
                        if (currentJsonProperty is not null)
                        {
                            ParseJsonArray(buffer.ToArray(), null, currentJsonProperty);
                        }
                        buffer.Clear();
                        break;
                    case '"':
                        if (insideDoubleQuotes)
                        {
                            if (encounteredBackslash)
                            {
                                buffer.Add(jsonChars[i]);
                            }
                            else
                            {
                                if (currentJsonProperty is not null)
                                {
                                    if (encounteredColon && currentJsonProperty.JsonObjectValue is null)
                                    {
                                        currentJsonProperty.Value = new(buffer.ToArray());
                                    }
                                    else
                                    {
                                        currentJsonProperty.Name = new(buffer.ToArray());
                                    }
                                    buffer.Clear();
                                }
                                insideDoubleQuotes = false;
                            }
                        }
                        else
                        {
                            insideDoubleQuotes = true;
                        }
                        break;
                    case '\\':
                        if (encounteredBackslash)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        encounteredBackslash = !encounteredBackslash;
                        break;
                    case ':':
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        else
                        {
                            encounteredColon = true;
                        }
                        break;
                    case ',':
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        else
                        {
                            encounteredColon = false;
                            JsonProperty? newJsonProperty = new();
                            newJsonProperty.ParentJsonObject = currentJsonObject;
                            currentJsonProperty = newJsonProperty;
                            currentJsonObject?.JsonProperties.Add(newJsonProperty);
                        }
                        break;
                    default:
                        if (insideDoubleQuotes)
                        {
                            buffer.Add(jsonChars[i]);
                        }
                        break;
                }
            }

            return (jsonObject, -1);
        }

        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public static T? Deserialize<T>(T obj, string json)
        {
            if (obj is null || string.IsNullOrWhiteSpace(json))
                return default;

            Type type = obj.GetType();

            if (type is null || string.IsNullOrWhiteSpace(type.FullName) || 
                (!string.IsNullOrWhiteSpace(NamespaceScoped) && !type.FullName.StartsWith(NamespaceScoped)))
                return obj;

            char[] jsonChars = json.ToCharArray();

            (JsonObject? jsonObject, _) = ParseJson(jsonChars, 0, null);

            FillObjectWithValuesFromJsonObject(obj, jsonObject);

            return obj;
        }

        private static void GetJsonStringPrivate(StringBuilder json, object? obj)
        {
            if (obj is null)
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            Type type = obj.GetType();

            if (type is null || string.IsNullOrWhiteSpace(type.FullName) || 
                (!string.IsNullOrWhiteSpace(NamespaceScoped) && !type.FullName.StartsWith(NamespaceScoped)))
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            json.Append(NoWhitespace ? "{" : "{ ");

            foreach (Helpers.TypePropertyNameAlias typePropertyNameAlias in
                Helpers.ClassesHavingTypePropertyNameAliases.FirstOrDefault<Helpers.ClassHavingTypePropertyNameAliases>(
                x => x.Type == type).PropertyNameAliases)
            {
                GetJsonStringForPropertyOfObjectByType(json, obj, typePropertyNameAlias);
            }

            string tmp = json.ToString();
            json.Clear().Append(NoWhitespace ? $"{(tmp[^1] == ',' ? tmp[0..^1] : tmp)}}}," : $"{(tmp[^2..] == ", " ? tmp[0..^2] : tmp)} }}, ");
        }

        private static void GetJsonStringForPropertyOfObjectByType(StringBuilder json, object obj,
            Helpers.TypePropertyNameAlias typePropertyNameAlias)
        {
            if (string.IsNullOrWhiteSpace(typePropertyNameAlias.Name))
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            json.Append(NoWhitespace ? $@"""{(string.IsNullOrWhiteSpace(typePropertyNameAlias.Alias) ?
                    typePropertyNameAlias.Name : typePropertyNameAlias.Alias)}"":" :
                    $@"""{(string.IsNullOrWhiteSpace(typePropertyNameAlias.Alias) ?
                    typePropertyNameAlias.Name : typePropertyNameAlias.Alias)}"" : ");

            object? objVal = typePropertyNameAlias.PropertyInfo.GetValue(obj, null);

            if (objVal is null)
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            switch (typePropertyNameAlias.JsonType)
            {
                case Helpers.JsonType.String:
                case Helpers.JsonType.Char:
                case Helpers.JsonType.Other:
                case Helpers.JsonType.Integer:
                case Helpers.JsonType.Double:
                case Helpers.JsonType.Number:
                case Helpers.JsonType.Boolean:
                case Helpers.JsonType.Byte:
                    GetJsonByJsonTypeEnum(json, objVal, typePropertyNameAlias.JsonType);
                    break;
                case Helpers.JsonType.Class:
                    GetJsonStringPrivate(json, objVal);
                    break;
                case Helpers.JsonType.StringArray:
                    GetJsonForArray<string>(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.CharArray:
                    GetJsonForArray<char>(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.IntegerArray:
                    GetJsonForArray<int>(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.DoubleArray:
                    GetJsonForArray<double>(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.NumberArray:
                    GetJsonForNumberArray(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.BooleanArray:
                    GetJsonForArray<bool>(json, obj, typePropertyNameAlias);
                    break;
                case Helpers.JsonType.ByteArray:
                    if (objVal is byte[] data)
                        json.Append(NoWhitespace ? $"\"{Convert.ToBase64String(data)}\"," : $"\"{Convert.ToBase64String(data)}\", ");
                    else
                        json.Append(NoWhitespace ? "null," : "null, ");
                    break;
                case Helpers.JsonType.ClassArray:
                    if (objVal is Array classArr)
                    {
                        json.Append(NoWhitespace ? "[" : "[ ");
                        foreach (object classItem in classArr)
                        {
                            GetJsonStringPrivate(json, classItem);
                        }
                        json.Append(NoWhitespace ? "]," : " ], ");
                    }
                    else
                    {
                        json.Append(NoWhitespace ? "null," : "null, ");
                    }
                    break;
            }
        }

        private static void GetJsonByJsonTypeEnum(StringBuilder json, object? objVal, Helpers.JsonType jsonType)
        {
            if (objVal is null)
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            switch (jsonType)
            {
                case Helpers.JsonType.String:
                case Helpers.JsonType.StringArray:
                case Helpers.JsonType.Char:
                case Helpers.JsonType.CharArray:
                case Helpers.JsonType.Other:
                    json.Append(NoWhitespace ? $"\"{objVal}\"," : $"\"{objVal}\", ");
                    break;
                case Helpers.JsonType.Integer:
                case Helpers.JsonType.IntegerArray:
                case Helpers.JsonType.Double:
                case Helpers.JsonType.DoubleArray:
                    json.Append(NoWhitespace ? $"{objVal}," : $"{objVal}, ");
                    break;
                case Helpers.JsonType.Number:
                case Helpers.JsonType.NumberArray:
                    json.Append(NoWhitespace ? $"{Convert.ToDouble(objVal)}," : $"{Convert.ToDouble(objVal)}, ");
                    break;
                case Helpers.JsonType.Boolean:
                case Helpers.JsonType.BooleanArray:
                    json.Append(NoWhitespace ? $"{objVal?.ToString()?.ToLower()}," : $"{objVal?.ToString()?.ToLower()}, ");
                    break;
                case Helpers.JsonType.Byte:
                    json.Append(NoWhitespace ? $"\"{Convert.ToBase64String(new byte[] { Convert.ToByte(objVal) })}\"," :
                        $"\"{Convert.ToBase64String(new byte[] { Convert.ToByte(objVal) })}\", ");
                    break;
            }
        }

        private static void GetJsonForNumberArray(StringBuilder json, object obj, Helpers.TypePropertyNameAlias typePropertyNameAlias)
        {
            if (obj is null)
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            json.Append(NoWhitespace ? "[" : "[ ");
            if (typePropertyNameAlias.PropertyInfo.GetValue(obj, null) is Array arr)
            {
                foreach (object objInArr in arr)
                {
                    GetJsonByJsonTypeEnum(json, objInArr, Helpers.JsonType.Number);
                }
            }
            string tmp = json.ToString();
            json.Clear().Append(NoWhitespace ? $"{(tmp[^2..] == "," ? tmp[0..^2] : tmp)}]," : $"{(tmp[^2..] == ", " ? tmp[0..^2] : tmp)} ], ");
        }

        private static void GetJsonForArray<T>(StringBuilder json, object obj, Helpers.TypePropertyNameAlias typePropertyNameAlias)
        {
            if (obj is null)
            {
                json.Append(NoWhitespace ? "null," : "null, ");
                return;
            }

            json.Append(NoWhitespace ? "[" : "[ ");
            if (typePropertyNameAlias.PropertyInfo.GetValue(obj, null) is T[] arr)
            {
                foreach (T val in arr)
                {
                    GetJsonByJsonTypeEnum(json, val, typePropertyNameAlias.JsonType);
                }
            }
            string tmp = json.ToString();
            json.Clear().Append(NoWhitespace ? $"{(tmp[^1] == ',' ? tmp[0..^1] : tmp)}]," : $"{(tmp[^2..] == ", " ? tmp[0..^2] : tmp)} ], ");
        }

        /// <value>
        /// <c>AccessToken</c> Refer to docs URI link web page.
        /// </value>
        public static string? Serialize(object? obj)
        {
            if (obj is null)
                return null;

            StringBuilder json = new();

            GetJsonStringPrivate(json, obj);

            string tmp = json.ToString();
            if (NoWhitespace)
            {
                return tmp[^1] == ',' ? tmp[0..^1] : tmp;
            }
            else
            {
                return tmp[^2..] == ", " ? tmp[0..^2] : tmp;
            }
        }
    }
}
