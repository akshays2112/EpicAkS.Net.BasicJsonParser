using System.Text;
using System.Text.Json.Serialization;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.EpicAkSTestingIfAllTypesWork
{
    #region Original Test Classes

    /// <summary>
    /// <c>X1</c> Only for testing purposes.
    /// </summary>
    public class X1
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop1_string")]
        public string X1_Prop1 { get; set; } = string.Empty;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop2_nullable_string")]
        public string? X1_Prop2 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop3_class_A2")]
        public A2 X1_Prop3 { get; set; } = new();

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop4_nullable_class_A2")]
        public A2? X1_Prop4 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop5_char")]
        public char X1_Prop5 { get; set; } = '2';

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop6_nullable_char")]
        public char? X1_Prop6 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop7_int")]
        public int X1_Prop7 { get; set; } = 3;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop8_nullable_int")]
        public int? X1_Prop8 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop9_classArray_A2")]
        public A2[] X1_Prop9 { get; set; } = Array.Empty<A2>();

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop10_nullable_classArray_A2")]
        public A2[]? X1_Prop10 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop11_bool")]
        public bool X1_Prop11 { get; set; } = true;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop12_bool")]
        public bool X1_Prop12 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop13_nullable_bool")]
        public bool? X1_Prop13 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop14_double")]
        public double X1_Prop14 { get; set; } = 4.89567435;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop15_nullable_double")]
        public double? X1_Prop15 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop16_float")]
        public float X1_Prop16 { get; set; } = 8.395676F;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop17_nullable_float")]
        public float? X1_Prop17 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop18_byte")]
        public byte X1_Prop18 { get; set; } = 0x5A;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop19_nullable_byte")]
        public byte? X1_Prop19 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop20_byteArray")]
        public byte[] X1_Prop20 { get; set; } = Convert.FromBase64String(Convert.ToBase64String(Encoding.Unicode.GetBytes("Akshay")));

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("x1_prop21_nullable_byteArray")]
        public byte[]? X1_Prop21 { get; set; }
    }

    /// <summary>
    /// <c>A2</c> Only for testing purposes.
    /// </summary>
    public class A2
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop1_string")]
        public string A2_Prop1 { get; set; } = string.Empty;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop2_nullable_string")]
        public string? A2_Prop2 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop3_nullable_class_A2")]
        public A2? A2_Prop3 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop4_char")]
        public char A2_Prop4 { get; set; } = '5';

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop5_nullable_char")]
        public char? A2_Prop5 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop6_int")]
        public int A2_Prop6 { get; set; } = 9;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop7_nullable_int")]
        public int? A2_Prop7 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop8_nullable_classArray_A2")]
        public A2[]? A2_Prop8 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop9_bool")]
        public bool A2_Prop9 { get; set; } = true;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop10_bool")]
        public bool A2_Prop10 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop11_nullable_bool")]
        public bool? A2_Prop11 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop12_double")]
        public double A2_Prop12 { get; set; } = 6.26542;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop13_nullable_double")]
        public double? A2_Prop13 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop14_float")]
        public float A2_Prop14 { get; set; } = 1.26542F;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop15_nullable_float")]
        public float? A2_Prop15 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop16_byte")]
        public byte A2_Prop16 { get; set; } = 255;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop17_nullable_byte")]
        public byte? A2_Prop17 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop18_byteArray")]
        public byte[] A2_Prop18 { get; set; } = Convert.FromBase64String(Convert.ToBase64String(Encoding.Unicode.GetBytes("Srinivasan")));

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("a2_prop19_nullable_byteArray")]
        public byte[]? A2_Prop19 { get; set; }
    }

    /// <summary>
    /// <c>J3</c> Only for testing purposes.
    /// </summary>
    public class J3
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSSkipPropertyAttribute()]
        public string J3_Prop1 { get; set; } = string.Empty;

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j3_prop2_nullable_string")]
        public string? J3_Prop2 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        public string? J3_Prop3 { get; set; }

        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j3_prop4_nullable_j4")]
        public J4? J3_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>J4</c> Only for testing purposes.
    /// </summary>
    public class J4
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j4_prop1")]
        public string J4_Prop1 { get; set; } = String.Empty;
    }

    /// <summary>
    /// <c>IJ6</c> Only for testing purposes.
    /// </summary>
    public interface IJ6
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        public string[] J6_Prop1 { get; set; }
    }

    /// <summary>
    /// <c>J6</c> Only for testing purposes.
    /// </summary>
    public class J6 : IJ6
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j6_prop1")]
        public string[] J6_Prop1 { get; set; } = new string[] { "Swiggy", "Zomato" };
    }

    /// <summary>
    /// <c>J7</c> Only for testing purposes.
    /// </summary>
    public class J7
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j7_prop1")]
        public J6[] J7_Prop1 { get; set; } = new J6[] { new(), new J6 { J6_Prop1 = new string[] { "Dad", "Mom" } } };
    }

    /// <summary>
    /// <c>J8</c> Only for testing purposes.
    /// </summary>
    public class J8
    {
        /// <value>
        /// <c>AccessToken</c> Only for testing purposes.
        /// </value>
        [EpicAkSPropertyNameAliasAttribute("j8_prop1")]
        public IJ6[] J8_Prop1 { get; set; } = new J6[] { new(), new J6 { J6_Prop1 = new string[] { "Dad", "Mom" } } };
    }

    #endregion

    #region New Test Classes

    /// <summary>
    /// <c>TC_Strings</c> Only for testing purposes.
    /// </summary>
    public class TC_Strings
    {
        /// <value>
        /// <c>TC_Strings_String_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_strings_string_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_strings_string_prop1")]
        public string TC_Strings_String_Prop1 { get; set; } = string.Empty;

        /// <value>
        /// <c>TC_Strings_NullableString_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_strings_nullableString_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_strings_nullableString_prop2")]
        public string? TC_Strings_NullableString_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Strings_String_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_strings_string_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_strings_string_prop3")]
        public String TC_Strings_String_Prop3 { get; set; } = string.Empty;

        /// <value>
        /// <c>TC_Strings_NullableString_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_strings_nullableString_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_strings_nullableString_prop4")]
        public String? TC_Strings_NullableString_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_StringArray</c> Only for testing purposes.
    /// </summary>
    public class TC_StringArrays
    {
        /// <value>
        /// <c>TC_StringArrays_StringArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_stringArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_stringArray_prop1")]
        public string[] TC_StringArrays_StringArray_Prop1 { get; set; } = Array.Empty<string>();

        /// <value>
        /// <c>TC_StringArrays_NullableStringArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_nullableStringArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_nullableStringArray_prop2")]
        public string?[] TC_StringArrays_NullableStringArray_Prop2 { get; set; } = Array.Empty<string?>();

        /// <value>
        /// <c>TC_StringArrays_StringArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_stringArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_stringArrayNullable_prop3")]
        public string[]? TC_StringArrays_StringArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_StringArrays_NullableStringArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_nullableStringArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_nullableStringArrayNullable_prop4")]
        public string?[]? TC_StringArrays_NullableStringArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_StringArrays_StringArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_stringArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_stringArray_prop5")]
        public String[] TC_StringArrays_StringArray_Prop5 { get; set; } = Array.Empty<string>();

        /// <value>
        /// <c>TC_StringArrays_NullableStringArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_nullableStringArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_nullableStringArray_prop6")]
        public String?[] TC_StringArrays_NullableStringArray_Prop6 { get; set; } = Array.Empty<string?>();

        /// <value>
        /// <c>TC_StringArrays_StringArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_stringArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_stringArrayNullable_prop7")]
        public String[]? TC_StringArrays_StringArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_StringArrays_NullableStringArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_stringArrays_nullableStringArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_stringArrays_nullableStringArrayNullable_prop8")]
        public String?[]? TC_StringArrays_NullableStringArrayNullable_Prop8 { get; set; }
    }

    /// <summary>
    /// <c>TC_Bools</c> Only for testing purposes.
    /// </summary>
    public class TC_Bools
    {
        /// <value>
        /// <c>TC_Bools_Bool_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bools_bool_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_bools_bool_prop1")]
        public bool TC_Bools_Bool_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Bools_NullableBool_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bools_nullableBool_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_bools_nullableBool_prop2")]
        public bool? TC_Bools_NullableBool_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Bools_Boolean_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bools_boolean_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_bools_boolean_prop3")]
        public Boolean TC_Bools_Boolean_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Bools_NullableBoolean_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bools_nullableBoolean_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_bools_nullableBoolean_prop4")]
        public Boolean? TC_Bools_NullableBoolean_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_BoolArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_BoolArrays
    {
        /// <value>
        /// <c>TC_BoolArrays_BoolArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_boolArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_boolArray_prop1")]
        public bool[] TC_BoolArrays_BoolArray_Prop1 { get; set; } = Array.Empty<bool>();

        /// <value>
        /// <c>TC_BoolArrays_NullableBoolArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_nullableBoolArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_nullableBoolArray_prop2")]
        public bool?[] TC_BoolArrays_NullableBoolArray_Prop2 { get; set; } = Array.Empty<bool?>();

        /// <value>
        /// <c>TC_BoolArrays_BoolArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_boolArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_boolArrayNullable_prop3")]
        public bool[]? TC_BoolArrays_BoolArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_BoolArrays_NullableBoolArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_nullableBoolArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_nullableBoolArrayNullable_prop4")]
        public bool?[]? TC_BoolArrays_NullableBoolArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_BoolArrays_BooleanArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_booleanArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_booleanArray_prop5")]
        public Boolean[] TC_BoolArrays_BooleanArray_Prop5 { get; set; } = Array.Empty<Boolean>();

        /// <value>
        /// <c>TC_BoolArrays_NullableBooleanArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_nullableBooleanArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_nullableBooleanArray_prop6")]
        public Boolean?[] TC_BoolArrays_NullableBooleanArray_Prop6 { get; set; } = Array.Empty<Boolean?>();

        /// <value>
        /// <c>TC_BoolArrays_BooleanArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_booleanArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_booleanArrayNullable_prop7")]
        public bool[]? TC_BoolArrays_BooleanArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_BoolArrays_NullableBooleanArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_boolArrays_nullableBooleanArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_boolArrays_nullableBooleanArrayNullable_prop8")]
        public bool?[]? TC_BoolArrays_NullableBooleanArrayNullable_Prop8 { get; set; }
    }

    /// <summary>
    /// <c>TC_Ints</c> Only for testing purposes.
    /// </summary>
    public class TC_Ints
    {
        /// <value>
        /// <c>TC_Ints_Int_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_int_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_int_prop1")]
        public int TC_Ints_Int_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Ints_NullableInt_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_nullableInt_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_nullableInt_prop2")]
        public int? TC_Ints_NullableInt_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Ints_Int16_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_int16_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_int16_prop3")]
        public Int16 TC_Ints_Int16_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Ints_NullableInt16_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_nullableInt16_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_nullableInt16_prop4")]
        public Int16? TC_Ints_NullableInt16_Prop4 { get; set; }

        /// <value>
        /// <c>TC_Ints_Int32_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_int32_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_int32_prop5")]
        public Int32 TC_Ints_Int32_Prop5 { get; set; }

        /// <value>
        /// <c>TC_Ints_NullableInt32_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_nullableInt32_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_nullableInt32_prop6")]
        public Int32? TC_Ints_NullableInt32_Prop6 { get; set; }

        /// <value>
        /// <c>TC_Ints_Int64_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_int64_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_int64_prop7")]
        public Int64 TC_Ints_Int64_Prop7 { get; set; }

        /// <value>
        /// <c>TC_Ints_NullableInt64_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_nullableInt64_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_nullableInt64_prop8")]
        public Int64? TC_Ints_NullableInt64_Prop8 { get; set; }

        /// <value>
        /// <c>TC_Ints_IntPtr_Prop9</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_intPtr_prop9")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_intPtr_prop9")]
        public IntPtr TC_Ints_IntPtr_Prop9 { get; set; }

        /// <value>
        /// <c>TC_Ints_NullableIntPtr_Prop10</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ints_nullableIntPtr_prop10")]
        [EpicAkSPropertyNameAliasAttribute("tc_ints_nullableIntPtr_prop10")]
        public IntPtr? TC_Ints_NullableIntPtr_Prop10 { get; set; }
    }

    /// <summary>
    /// <c>TC_IntArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_IntArrays
    {
        /// <value>
        /// <c>TC_IntArrays_IntArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intArrays_intArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_intArrays_intArray_prop1")]
        public int[] TC_IntArrays_IntArray_Prop1 { get; set; } = Array.Empty<int>();

        /// <value>
        /// <c>TC_IntArrays_NullableIntArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intArrays_nullableIntArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_intArrays_nullableIntArray_prop2")]
        public int?[] TC_IntArrays_NullableIntArray_Prop2 { get; set; } = Array.Empty<int?>();

        /// <value>
        /// <c>TC_IntArrays_IntArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intArrays_intArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_intArrays_intArrayNullable_prop3")]
        public int[]? TC_IntArrays_IntArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableIntArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_nullableIntArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_nullableIntArrayNullable_prop4")]
        public int?[]? TC_IntArrays_NullableIntArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_Int16Array_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_int16Array_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_int16Array_prop5")]
        public Int16[] TC_IntArrays_Int16Array_Prop5 { get; set; } = Array.Empty<Int16>();

        /// <value>
        /// <c>TC_IntArrays_NullableInt16Array_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_nullableInt16Array_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_nullableInt16Array_prop6")]
        public Int16?[] TC_IntArrays_NullableInt16Array_Prop6 { get; set; } = Array.Empty<Int16?>();

        /// <value>
        /// <c>TC_IntArrays_Int16ArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_int16ArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_int16ArrayNullable_prop7")]
        public Int16[]? TC_IntArrays_Int16ArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableInt16ArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_nullableInt16ArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_nullableInt16ArrayNullable_prop8")]
        public Int16?[]? TC_IntArrays_NullableInt16ArrayNullable_Prop8 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableIntArrayNullable_Prop9</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int16Arrays_nullableIntArrayNullable_prop9")]
        [EpicAkSPropertyNameAliasAttribute("tc_int16Arrays_nullableIntArrayNullable_prop9")]
        public Int16?[]? TC_IntArrays_NullableIntArrayNullable_Prop9 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_Int32Array_Prop10</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int32Arrays_int32Array_prop10")]
        [EpicAkSPropertyNameAliasAttribute("tc_int32Arrays_int32Array_prop10")]
        public Int32[] TC_IntArrays_Int32Array_Prop10 { get; set; } = Array.Empty<Int32>();

        /// <value>
        /// <c>TC_IntArrays_NullableInt32Array_Prop11</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int32Arrays_nullableInt32Array_prop11")]
        [EpicAkSPropertyNameAliasAttribute("tc_int32Arrays_nullableInt32Array_prop11")]
        public Int32?[] TC_IntArrays_NullableInt32Array_Prop11 { get; set; } = Array.Empty<Int32?>();

        /// <value>
        /// <c>TC_IntArrays_Int32ArrayNullable_Prop12</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int32Arrays_int32ArrayNullable_prop12")]
        [EpicAkSPropertyNameAliasAttribute("tc_int32Arrays_int32ArrayNullable_prop12")]
        public Int32[]? TC_IntArrays_Int32ArrayNullable_Prop12 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableInt32ArrayNullable_Prop13</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int32Arrays_nullableInt32ArrayNullable_prop13")]
        [EpicAkSPropertyNameAliasAttribute("tc_int32Arrays_nullableInt32ArrayNullable_prop13")]
        public Int32?[]? TC_IntArrays_NullableInt32ArrayNullable_Prop13 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_Int64Array_Prop14</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int64Arrays_int64Array_prop14")]
        [EpicAkSPropertyNameAliasAttribute("tc_int64Arrays_int64Array_prop14")]
        public Int64[] TC_IntArrays_Int64Array_Prop14 { get; set; } = Array.Empty<Int64>();

        /// <value>
        /// <c>TC_IntArrays_NullableInt64Array_Prop15</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int64Arrays_nullableInt64Array_prop15")]
        [EpicAkSPropertyNameAliasAttribute("tc_int64Arrays_nullableInt64Array_prop15")]
        public Int64?[] TC_IntArrays_NullableInt64Array_Prop15 { get; set; } = Array.Empty<Int64?>();

        /// <value>
        /// <c>TC_IntArrays_Int64ArrayNullable_Prop16</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int64Arrays_int64ArrayNullable_prop16")]
        [EpicAkSPropertyNameAliasAttribute("tc_int64Arrays_int64ArrayNullable_prop16")]
        public Int64[]? TC_IntArrays_Int64ArrayNullable_Prop16 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableInt64ArrayNullable_Prop17</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_int64Arrays_nullableInt64ArrayNullable_prop17")]
        [EpicAkSPropertyNameAliasAttribute("tc_int64Arrays_nullableInt64ArrayNullable_prop17")]
        public Int64?[]? TC_IntArrays_NullableInt64ArrayNullable_Prop17 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_IntPtrArray_Prop14</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intPtrArrays_intPtrArray_prop14")]
        [EpicAkSPropertyNameAliasAttribute("tc_intPtrArrays_intPtrArray_prop14")]
        public IntPtr[] TC_IntArrays_IntPtrArray_Prop14 { get; set; } = Array.Empty<IntPtr>();

        /// <value>
        /// <c>TC_IntArrays_NullableIntPtrArray_Prop15</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intPtrArrays_nullableIntPtrArray_prop15")]
        [EpicAkSPropertyNameAliasAttribute("tc_intPtrArrays_nullableIntPtrArray_prop15")]
        public IntPtr?[] TC_IntArrays_NullableIntPtrArray_Prop15 { get; set; } = Array.Empty<IntPtr?>();

        /// <value>
        /// <c>TC_IntArrays_IntPtrArrayNullable_Prop16</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intPtrArrays_intPtrArrayNullable_prop16")]
        [EpicAkSPropertyNameAliasAttribute("tc_intPtrArrays_intPtrArrayNullable_prop16")]
        public IntPtr[]? TC_IntArrays_IntPtrArrayNullable_Prop16 { get; set; }

        /// <value>
        /// <c>TC_IntArrays_NullableIntPtrArrayNullable_Prop17</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_intPtrArrays_nullableIntPtrArrayNullable_prop17")]
        [EpicAkSPropertyNameAliasAttribute("tc_intPtrArrays_nullableIntPtrArrayNullable_prop17")]
        public IntPtr?[]? TC_IntArrays_NullableIntPtrArrayNullable_Prop17 { get; set; }
    }

    /// <summary>
    /// <c>TC_UInts</c> Only for testing purposes.
    /// </summary>
    public class TC_UInts
    {
        /// <value>
        /// <c>TC_UInts_UInt_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_uint_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_uint_prop1")]
        public uint TC_UInts_UInt_Prop1 { get; set; }

        /// <value>
        /// <c>TC_UInts_NullableUInt_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_nullableUInt_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_nullableUInt_prop2")]
        public uint? TC_UInts_NullableUInt_Prop2 { get; set; }

        /// <value>
        /// <c>TC_UInts_UInt16_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_uint16_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_uint16_prop3")]
        public UInt16 TC_UInts_UInt16_Prop3 { get; set; }

        /// <value>
        /// <c>TC_UInts_NullableUInt16_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_nullableUInt16_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_nullableUInt16_prop4")]
        public UInt16? TC_UInts_NullableUInt16_Prop4 { get; set; }

        /// <value>
        /// <c>TC_UInts_UInt32_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_uint32_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_uint32_prop5")]
        public UInt32 TC_UInts_UInt32_Prop5 { get; set; }

        /// <value>
        /// <c>TC_UInts_NullableUInt32_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_nullableUInt32_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_nullableUInt32_prop6")]
        public UInt32? TC_UInts_NullableUInt32_Prop6 { get; set; }

        /// <value>
        /// <c>TC_UInts_UInt64_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_uint64_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_uint64_prop7")]
        public UInt64 TC_UInts_UInt64_Prop7 { get; set; }

        /// <value>
        /// <c>TC_UInts_NullableUInt64_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_nullableUInt64_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_nullableUInt64_prop8")]
        public UInt64? TC_UInts_NullableUInt64_Prop8 { get; set; }

        /// <value>
        /// <c>TC_UInts_UIntPtr_Prop9</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_uintPtr_prop9")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_uintPtr_prop9")]
        public UIntPtr TC_UInts_UIntPtr_Prop9 { get; set; }

        /// <value>
        /// <c>TC_UInts_NullableUIntPtr_Prop10</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uints_nullableUIntPtr_prop10")]
        [EpicAkSPropertyNameAliasAttribute("tc_uints_nullableUIntPtr_prop10")]
        public UIntPtr? TC_UInts_NullableUIntPtr_Prop10 { get; set; }
    }

    /// <summary>
    /// <c>TC_UIntArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_UIntArrays
    {
        /// <value>
        /// <c>TC_UIntArrays_UIntArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintArrays_uintArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintArrays_uintArray_prop1")]
        public uint[] TC_UIntArrays_UIntArray_Prop1 { get; set; } = Array.Empty<uint>();

        /// <value>
        /// <c>TC_UIntArrays_NullableUIntArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintArrays_nullableUIntArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintArrays_nullableUIntArray_prop2")]
        public uint?[] TC_UIntArrays_NullableUIntArray_Prop2 { get; set; } = Array.Empty<uint?>();

        /// <value>
        /// <c>TC_UIntArrays_UIntArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintArrays_uintArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintArrays_uintArrayNullable_prop3")]
        public uint[]? TC_UIntArrays_UIntArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUIntArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_nullableUIntArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_nullableUIntArrayNullable_prop4")]
        public uint?[]? TC_UIntArrays_NullableUIntArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_UInt16Array_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_uint16Array_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_uint16Array_prop5")]
        public UInt16[] TC_UIntArrays_UInt16Array_Prop5 { get; set; } = Array.Empty<UInt16>();

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt16Array_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_nullableUInt16Array_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_nullableUInt16Array_prop6")]
        public UInt16?[] TC_UIntArrays_NullableUInt16Array_Prop6 { get; set; } = Array.Empty<UInt16?>();

        /// <value>
        /// <c>TC_UIntArrays_UInt16ArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_uint16ArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_uint16ArrayNullable_prop7")]
        public UInt16[]? TC_UIntArrays_UInt16ArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt16ArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_nullableUInt16ArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_nullableUInt16ArrayNullable_prop8")]
        public UInt16?[]? TC_UIntArrays_NullableUInt16ArrayNullable_Prop8 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUIntArrayNullable_Prop9</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint16Arrays_nullableUIntArrayNullable_prop9")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint16Arrays_nullableUIntArrayNullable_prop9")]
        public UInt16?[]? TC_UIntArrays_NullableUIntArrayNullable_Prop9 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_UInt32Array_Prop10</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint32Arrays_uint32Array_prop10")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint32Arrays_uint32Array_prop10")]
        public UInt32[] TC_UIntArrays_UInt32Array_Prop10 { get; set; } = Array.Empty<UInt32>();

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt32Array_Prop11</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint32Arrays_nullableUInt32Array_prop11")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint32Arrays_nullableUInt32Array_prop11")]
        public UInt32?[] TC_UIntArrays_NullableUInt32Array_Prop11 { get; set; } = Array.Empty<UInt32?>();

        /// <value>
        /// <c>TC_UIntArrays_UInt32ArrayNullable_Prop12</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint32Arrays_uint32ArrayNullable_prop12")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint32Arrays_uint32ArrayNullable_prop12")]
        public UInt32[]? TC_UIntArrays_UInt32ArrayNullable_Prop12 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt32ArrayNullable_Prop13</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint32Arrays_nullableUInt32ArrayNullable_prop13")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint32Arrays_nullableUInt32ArrayNullable_prop13")]
        public UInt32?[]? TC_UIntArrays_NullableUInt32ArrayNullable_Prop13 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_UInt64Array_Prop14</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint64Arrays_uint64Array_prop14")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint64Arrays_uint64Array_prop14")]
        public UInt64[] TC_UIntArrays_UInt64Array_Prop14 { get; set; } = Array.Empty<UInt64>();

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt64Array_Prop15</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint64Arrays_nullableUInt64Array_prop15")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint64Arrays_nullableUInt64Array_prop15")]
        public UInt64?[] TC_UIntArrays_NullableUInt64Array_Prop15 { get; set; } = Array.Empty<UInt64?>();

        /// <value>
        /// <c>TC_UIntArrays_UInt64ArrayNullable_Prop16</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint64Arrays_uint64ArrayNullable_prop16")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint64Arrays_uint64ArrayNullable_prop16")]
        public UInt64[]? TC_UIntArrays_UInt64ArrayNullable_Prop16 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUInt64ArrayNullable_Prop17</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uint64Arrays_nullableUInt64ArrayNullable_prop17")]
        [EpicAkSPropertyNameAliasAttribute("tc_uint64Arrays_nullableUInt64ArrayNullable_prop17")]
        public UInt64?[]? TC_UIntArrays_NullableUInt64ArrayNullable_Prop17 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_UIntPtrArray_Prop14</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintPtrArrays_uintPtrArray_prop14")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintPtrArrays_uintPtrArray_prop14")]
        public UIntPtr[] TC_UIntArrays_UIntPtrArray_Prop14 { get; set; } = Array.Empty<UIntPtr>();

        /// <value>
        /// <c>TC_UIntArrays_NullableUIntPtrArray_Prop15</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintPtrArrays_nullableUIntPtrArray_prop15")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintPtrArrays_nullableUIntPtrArray_prop15")]
        public UIntPtr?[] TC_UIntArrays_NullableUIntPtrArray_Prop15 { get; set; } = Array.Empty<UIntPtr?>();

        /// <value>
        /// <c>TC_UIntArrays_UIntPtrArrayNullable_Prop16</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintPtrArrays_uintPtrArrayNullable_prop16")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintPtrArrays_uintPtrArrayNullable_prop16")]
        public UIntPtr[]? TC_UIntArrays_UIntPtrArrayNullable_Prop16 { get; set; }

        /// <value>
        /// <c>TC_UIntArrays_NullableUIntPtrArrayNullable_Prop17</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_uintPtrArrays_nullableUIntPtrArrayNullable_prop17")]
        [EpicAkSPropertyNameAliasAttribute("tc_uintPtrArrays_nullableUIntPtrArrayNullable_prop17")]
        public UIntPtr?[]? TC_UIntArrays_NullableUIntPtrArrayNullable_Prop17 { get; set; }
    }

    /// <summary>
    /// <c>TC_Doubles</c> Only for testing purposes.
    /// </summary>
    public class TC_Doubles
    {
        /// <value>
        /// <c>TC_Doubles_Double_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubles_double_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubles_double_prop1")]
        public double TC_Doubles_Double_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Doubles_NullableDouble_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubles_nullableDouble_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubles_nullableDouble_prop2")]
        public double? TC_Doubles_NullableDouble_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Doubles_Double_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubles_double_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubles_double_prop3")]
        public Double TC_Doubles_Double_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Doubles_NullableDouble_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubles_nullableDouble_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubles_nullableDouble_prop4")]
        public Double? TC_Doubles_NullableDouble_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_DoubleArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_DoubleArrays
    {
        /// <value>
        /// <c>TC_DoubleArrays_DoubleArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_doubleArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_doubleArray_prop1")]
        public double[] TC_DoubleArrays_DoubleArray_Prop1 { get; set; } = Array.Empty<double>();

        /// <value>
        /// <c>TC_DoubleArrays_NullableDoubleArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_nullableDoubleArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_nullableDoubleArray_prop2")]
        public double?[] TC_DoubleArrays_NullableDoubleArray_Prop2 { get; set; } = Array.Empty<double?>();

        /// <value>
        /// <c>TC_DoubleArrays_DoubleArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_doubleArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_doubleArrayNullable_prop3")]
        public double[]? TC_DoubleArrays_DoubleArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_DoubleArrays_NullableDoubleArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_nullableDoubleArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_nullableDoubleArrayNullable_prop4")]
        public double?[]? TC_DoubleArrays_NullableDoubleArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_DoubleArrays_DoubleArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_doubleArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_doubleArray_prop5")]
        public Double[] TC_DoubleArrays_DoubleArray_Prop5 { get; set; } = Array.Empty<Double>();

        /// <value>
        /// <c>TC_DoubleArrays_NullableDoubleArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_nullableDoubleArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_nullableDoubleArray_prop6")]
        public Double?[] TC_DoubleArrays_NullableDoubleArray_Prop6 { get; set; } = Array.Empty<Double?>();

        /// <value>
        /// <c>TC_DoubleArrays_DoubleArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_doubleArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_doubleArrayNullable_prop7")]
        public Double[]? TC_DoubleArrays_DoubleArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_DoubleArrays_NullableDoubleArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_nullableDoubleArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_nullableDoubleArrayNullable_prop8")]
        public Double?[]? TC_DoubleArrays_NullableDoubleArrayNullable_Prop8 { get; set; }

        /// <value>
        /// <c>TC_DoubleArrays_NullableDoubleArrayNullable_Prop9</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_doubleArrays_nullableDoubleArrayNullable_prop9")]
        [EpicAkSPropertyNameAliasAttribute("tc_doubleArrays_nullableDoubleArrayNullable_prop9")]
        public Double?[]? TC_DoubleArrays_NullableDoubleArrayNullable_Prop9 { get; set; }
    }

    /// <summary>
    /// <c>TC_Floats</c> Only for testing purposes.
    /// </summary>
    public class TC_Floats
    {
        /// <value>
        /// <c>TC_Floats_Float_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floats_float_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_floats_float_prop1")]
        public float TC_Floats_Float_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Floats_NullableFloat_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floats_nullableFloat_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_floats_nullableFloat_prop2")]
        public float? TC_Floats_NullableFloat_Prop2 { get; set; }
    }

    /// <summary>
    /// <c>TC_FloatArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_FloatArrays
    {
        /// <value>
        /// <c>TC_FloatArrays_FloatArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floatArrays_floatArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_floatArrays_floatArray_prop1")]
        public float[] TC_FloatArrays_FloatArray_Prop1 { get; set; } = Array.Empty<float>();

        /// <value>
        /// <c>TC_FloatArrays_NullableFloatArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floatArrays_nullableFloatArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_floatArrays_nullableFloatArray_prop2")]
        public float?[] TC_FloatArrays_NullableFloatArray_Prop2 { get; set; } = Array.Empty<float?>();

        /// <value>
        /// <c>TC_FloatArrays_FloatArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floatArrays_floatArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_floatArrays_floatArrayNullable_prop3")]
        public float[]? TC_FloatArrays_FloatArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_FloatArrays_NullableFloatArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_floatArrays_nullableFloatArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_floatArrays_nullableFloatArrayNullable_prop4")]
        public float?[]? TC_FloatArrays_NullableFloatArrayNullable_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_Longs</c> Only for testing purposes.
    /// </summary>
    public class TC_Longs
    {
        /// <value>
        /// <c>TC_Longs_Long_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longs_long_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_longs_long_prop1")]
        public long TC_Longs_Long_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Longs_NullableLong_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longs_nullableLong_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_longs_nullableLong_prop2")]
        public long? TC_Longs_NullableLong_Prop2 { get; set; }
    }

    /// <summary>
    /// <c>TC_LongArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_LongArrays
    {
        /// <value>
        /// <c>TC_LongArrays_LongArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longArrays_longArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_longArrays_longArray_prop1")]
        public long[] TC_LongArrays_LongArray_Prop1 { get; set; } = Array.Empty<long>();

        /// <value>
        /// <c>TC_LongArrays_NullableLongArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longArrays_nullableLongArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_longArrays_nullableLongArray_prop2")]
        public long?[] TC_LongArrays_NullableLongArray_Prop2 { get; set; } = Array.Empty<long?>();

        /// <value>
        /// <c>TC_LongArrays_LongArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longArrays_longArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_longArrays_longArrayNullable_prop3")]
        public long[]? TC_LongArrays_LongArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_LongArrays_NullableLongArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_longArrays_nullableLongArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_longArrays_nullableLongArrayNullable_prop4")]
        public long?[]? TC_LongArrays_NullableLongArrayNullable_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_Ulongs</c> Only for testing purposes.
    /// </summary>
    public class TC_Ulongs
    {
        /// <value>
        /// <c>TC_Ulongs_Ulong_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongs_ulong_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongs_ulong_prop1")]
        public ulong TC_Ulongs_Ulong_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Ulongs_NullableUlong_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongs_nullableUlong_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongs_nullableUlong_prop2")]
        public ulong? TC_Ulongs_NullableUlong_Prop2 { get; set; }
    }

    /// <summary>
    /// <c>TC_UlongArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_UlongArrays
    {
        /// <value>
        /// <c>TC_UlongArrays_UlongArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongArrays_ulongArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongArrays_ulongArray_prop1")]
        public ulong[] TC_UlongArrays_UlongArray_Prop1 { get; set; } = Array.Empty<ulong>();

        /// <value>
        /// <c>TC_UlongArrays_NullableUlongArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongArrays_nullableUlongArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongArrays_nullableUlongArray_prop2")]
        public ulong?[] TC_UlongArrays_NullableUlongArray_Prop2 { get; set; } = Array.Empty<ulong?>();

        /// <value>
        /// <c>TC_UlongArrays_UlongArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongArrays_ulongArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongArrays_ulongArrayNullable_prop3")]
        public ulong[]? TC_UlongArrays_UlongArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_UlongArrays_NullableUlongArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_ulongArrays_nullableUlongArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_ulongArrays_nullableUlongArrayNullable_prop4")]
        public ulong?[]? TC_UlongArrays_NullableUlongArrayNullable_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_Decimals</c> Only for testing purposes.
    /// </summary>
    public class TC_Decimals
    {
        /// <value>
        /// <c>TC_Decimals_Decimal_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimals_decimal_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimals_decimal_prop1")]
        public decimal TC_Decimals_Decimal_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Decimals_NullableDecimal_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimals_nullableDecimal_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimals_nullableDecimal_prop2")]
        public decimal? TC_Decimals_NullableDecimal_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Decimals_Decimal_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimals_decimal_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimals_decimal_prop3")]
        public Decimal TC_Decimals_Decimal_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Decimals_NullableDecimal_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimals_nullableDecimal_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimals_nullableDecimal_prop4")]
        public Decimal? TC_Decimals_NullableDecimal_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_DecimalArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_DecimalArrays
    {
        /// <value>
        /// <c>TC_DecimalArrays_DecimalArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_decimalArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_decimalArray_prop1")]
        public decimal[] TC_DecimalArrays_DecimalArray_Prop1 { get; set; } = Array.Empty<decimal>();

        /// <value>
        /// <c>TC_DecimalArrays_NullableDecimalArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_nullableDecimalArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_nullableDecimalArray_prop2")]
        public decimal?[] TC_DecimalArrays_NullableDecimalArray_Prop2 { get; set; } = Array.Empty<decimal?>();

        /// <value>
        /// <c>TC_DecimalArrays_DecimalArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_decimalArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_decimalArrayNullable_prop3")]
        public decimal[]? TC_DecimalArrays_DecimalArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_DecimalArrays_NullableDecimalArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_nullableDecimalArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_nullableDecimalArrayNullable_prop4")]
        public decimal?[]? TC_DecimalArrays_NullableDecimalArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_DecimalArrays_DecimalArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_decimalArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_decimalArray_prop5")]
        public Decimal[] TC_DecimalArrays_DecimalArray_Prop5 { get; set; } = Array.Empty<Decimal>();

        /// <value>
        /// <c>TC_DecimalArrays_NullableDecimalArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_nullableDecimalArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_nullableDecimalArray_prop6")]
        public Decimal?[] TC_DecimalArrays_NullableDecimalArray_Prop6 { get; set; } = Array.Empty<Decimal?>();

        /// <value>
        /// <c>TC_DecimalArrays_DecimalArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_decimalArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_decimalArrayNullable_prop7")]
        public Decimal[]? TC_DecimalArrays_DecimalArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_DecimalArrays_NullableDecimalArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_decimalArrays_nullableDecimalArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_decimalArrays_nullableDecimalArrayNullable_prop8")]
        public Decimal?[]? TC_DecimalArrays_NullableDecimalArrayNullable_Prop8 { get; set; }
    }

    /// <summary>
    /// <c>TC_Bytes</c> Only for testing purposes.
    /// </summary>
    public class TC_Bytes
    {
        /// <value>
        /// <c>TC_Bytes_Byte_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bytes_byte_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_bytes_byte_prop1")]
        public byte TC_Bytes_Byte_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Bytes_NullableByte_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bytes_nullableByte_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_bytes_nullableByte_prop2")]
        public byte? TC_Bytes_NullableByte_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Bytes_Byte_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bytes_byte_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_bytes_byte_prop3")]
        public Byte TC_Bytes_Byte_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Bytes_NullableByte_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_bytes_nullableByte_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_bytes_nullableByte_prop4")]
        public Byte? TC_Bytes_NullableByte_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_ByteArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_ByteArrays
    {
        /// <value>
        /// <c>TC_ByteArrays_ByteArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_byteArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_byteArray_prop1")]
        public byte[] TC_ByteArrays_ByteArray_Prop1 { get; set; } = Array.Empty<byte>();

        /// <value>
        /// <c>TC_ByteArrays_NullableByteArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_nullableByteArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_nullableByteArray_prop2")]
        public byte?[] TC_ByteArrays_NullableByteArray_Prop2 { get; set; } = Array.Empty<byte?>();

        /// <value>
        /// <c>TC_ByteArrays_ByteArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_byteArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_byteArrayNullable_prop3")]
        public byte[]? TC_ByteArrays_ByteArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_ByteArrays_NullableByteArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_nullableByteArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_nullableByteArrayNullable_prop4")]
        public byte?[]? TC_ByteArrays_NullableByteArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_ByteArrays_ByteArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_byteArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_byteArray_prop5")]
        public Byte[] TC_ByteArrays_ByteArray_Prop5 { get; set; } = Array.Empty<Byte>();

        /// <value>
        /// <c>TC_ByteArrays_NullableByteArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_nullableByteArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_nullableByteArray_prop6")]
        public Byte?[] TC_ByteArrays_NullableByteArray_Prop6 { get; set; } = Array.Empty<Byte?>();

        /// <value>
        /// <c>TC_ByteArrays_ByteArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_byteArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_byteArrayNullable_prop7")]
        public Byte[]? TC_ByteArrays_ByteArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_ByteArrays_NullableByteArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_byteArrays_nullableByteArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_byteArrays_nullableByteArrayNullable_prop8")]
        public Byte?[]? TC_ByteArrays_NullableByteArrayNullable_Prop8 { get; set; }
    }

    /// <summary>
    /// <c>TC_Chars</c> Only for testing purposes.
    /// </summary>
    public class TC_Chars
    {
        /// <value>
        /// <c>TC_Chars_Char_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_chars_char_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_chars_char_prop1")]
        public char TC_Chars_Char_Prop1 { get; set; }

        /// <value>
        /// <c>TC_Chars_NullableChar_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_chars_nullableChar_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_chars_nullableChar_prop2")]
        public char? TC_Chars_NullableChar_Prop2 { get; set; }

        /// <value>
        /// <c>TC_Chars_Char_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_chars_char_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_chars_char_prop3")]
        public Char TC_Chars_Char_Prop3 { get; set; }

        /// <value>
        /// <c>TC_Chars_NullableChar_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_chars_nullableChar_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_chars_nullableChar_prop4")]
        public Char? TC_Chars_NullableChar_Prop4 { get; set; }
    }

    /// <summary>
    /// <c>TC_CharArrays</c> Only for testing purposes.
    /// </summary>
    public class TC_CharArrays
    {
        /// <value>
        /// <c>TC_CharArrays_CharArray_Prop1</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_charArray_prop1")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_charArray_prop1")]
        public char[] TC_CharArrays_CharArray_Prop1 { get; set; } = Array.Empty<char>();

        /// <value>
        /// <c>TC_CharArrays_NullableCharArray_Prop2</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_nullableCharArray_prop2")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_nullableCharArray_prop2")]
        public char?[] TC_CharArrays_NullableCharArray_Prop2 { get; set; } = Array.Empty<char?>();

        /// <value>
        /// <c>TC_CharArrays_CharArrayNullable_Prop3</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_charArrayNullable_prop3")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_charArrayNullable_prop3")]
        public char[]? TC_CharArrays_CharArrayNullable_Prop3 { get; set; }

        /// <value>
        /// <c>TC_CharArrays_NullableCharArrayNullable_Prop4</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_nullableCharArrayNullable_prop4")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_nullableCharArrayNullable_prop4")]
        public char?[]? TC_CharArrays_NullableCharArrayNullable_Prop4 { get; set; }

        /// <value>
        /// <c>TC_CharArrays_CharArray_Prop5</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_charArray_prop5")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_charArray_prop5")]
        public Char[] TC_CharArrays_CharArray_Prop5 { get; set; } = Array.Empty<Char>();

        /// <value>
        /// <c>TC_CharArrays_NullableCharArray_Prop6</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_nullableCharArray_prop6")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_nullableCharArray_prop6")]
        public Char?[] TC_CharArrays_NullableCharArray_Prop6 { get; set; } = Array.Empty<Char?>();

        /// <value>
        /// <c>TC_CharArrays_CharArrayNullable_Prop7</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_charArrayNullable_prop7")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_charArrayNullable_prop7")]
        public Char[]? TC_CharArrays_CharArrayNullable_Prop7 { get; set; }

        /// <value>
        /// <c>TC_CharArrays_NullableCharArrayNullable_Prop8</c> Only for testing purposes.
        /// </value>
        [JsonPropertyName("tc_charArrays_nullableCharArrayNullable_prop8")]
        [EpicAkSPropertyNameAliasAttribute("tc_charArrays_nullableCharArrayNullable_prop8")]
        public Char?[]? TC_CharArrays_NullableCharArrayNullable_Prop8 { get; set; }
    }

    #endregion
}
