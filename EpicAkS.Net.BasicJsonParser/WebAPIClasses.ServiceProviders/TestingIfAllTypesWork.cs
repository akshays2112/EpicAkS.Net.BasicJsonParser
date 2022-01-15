using System.Text;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.TestingIfAllTypesWork
{
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
}
