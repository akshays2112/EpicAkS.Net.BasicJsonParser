using System.Text;

namespace EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.TestingIfAllTypesWork
{
    public class X1
    {
        [EpicAkSPropertyNameAliasAttribute("x1_prop1_string")]
        public string X1_Prop1 { get; set; } = string.Empty;

        [EpicAkSPropertyNameAliasAttribute("x1_prop2_nullable_string")]
        public string? X1_Prop2 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop3_class_A2")]
        public A2 X1_Prop3 { get; set; } = new();

        [EpicAkSPropertyNameAliasAttribute("x1_prop4_nullable_class_A2")]
        public A2? X1_Prop4 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop5_char")]
        public char X1_Prop5 { get; set; } = '2';

        [EpicAkSPropertyNameAliasAttribute("x1_prop6_nullable_char")]
        public char? X1_Prop6 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop7_int")]
        public int X1_Prop7 { get; set; } = 3;

        [EpicAkSPropertyNameAliasAttribute("x1_prop8_nullable_int")]
        public int? X1_Prop8 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop9_classArray_A2")]
        public A2[] X1_Prop9 { get; set; } = Array.Empty<A2>();

        [EpicAkSPropertyNameAliasAttribute("x1_prop10_nullable_classArray_A2")]
        public A2[]? X1_Prop10 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop11_bool")]
        public bool X1_Prop11 { get; set; } = true;

        [EpicAkSPropertyNameAliasAttribute("x1_prop12_bool")]
        public bool X1_Prop12 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop13_nullable_bool")]
        public bool? X1_Prop13 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop14_double")]
        public double X1_Prop14 { get; set; } = 4.89567435;

        [EpicAkSPropertyNameAliasAttribute("x1_prop15_nullable_double")]
        public double? X1_Prop15 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop16_float")]
        public float X1_Prop16 { get; set; } = 8.395676F;

        [EpicAkSPropertyNameAliasAttribute("x1_prop17_nullable_float")]
        public float? X1_Prop17 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop18_byte")]
        public byte X1_Prop18 { get; set; } = 0x5A;

        [EpicAkSPropertyNameAliasAttribute("x1_prop19_nullable_byte")]
        public byte? X1_Prop19 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("x1_prop20_byteArray")]
        public byte[] X1_Prop20 { get; set; } = Convert.FromBase64String(Convert.ToBase64String(Encoding.Unicode.GetBytes("Akshay")));

        [EpicAkSPropertyNameAliasAttribute("x1_prop21_nullable_byteArray")]
        public byte[]? X1_Prop21 { get; set; }
    }

    public class A2
    {
        [EpicAkSPropertyNameAliasAttribute("a2_prop1_string")]
        public string A2_Prop1 { get; set; } = string.Empty;

        [EpicAkSPropertyNameAliasAttribute("a2_prop2_nullable_string")]
        public string? A2_Prop2 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop3_nullable_class_A2")]
        public A2? A2_Prop3 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop4_char")]
        public char A2_Prop4 { get; set; } = '5';

        [EpicAkSPropertyNameAliasAttribute("a2_prop5_nullable_char")]
        public char? A2_Prop5 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop6_int")]
        public int A2_Prop6 { get; set; } = 9;

        [EpicAkSPropertyNameAliasAttribute("a2_prop7_nullable_int")]
        public int? A2_Prop7 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop8_nullable_classArray_A2")]
        public A2[]? A2_Prop8 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop9_bool")]
        public bool A2_Prop9 { get; set; } = true;

        [EpicAkSPropertyNameAliasAttribute("a2_prop10_bool")]
        public bool A2_Prop10 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop11_nullable_bool")]
        public bool? A2_Prop11 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop12_double")]
        public double A2_Prop12 { get; set; } = 6.26542;

        [EpicAkSPropertyNameAliasAttribute("a2_prop13_nullable_double")]
        public double? A2_Prop13 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop14_float")]
        public float A2_Prop14 { get; set; } = 1.26542F;

        [EpicAkSPropertyNameAliasAttribute("a2_prop15_nullable_float")]
        public float? A2_Prop15 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop16_byte")]
        public byte A2_Prop16 { get; set; } = 255;

        [EpicAkSPropertyNameAliasAttribute("a2_prop17_nullable_byte")]
        public byte? A2_Prop17 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("a2_prop18_byteArray")]
        public byte[] A2_Prop18 { get; set; } = Convert.FromBase64String(Convert.ToBase64String(Encoding.Unicode.GetBytes("Srinivasan")));

        [EpicAkSPropertyNameAliasAttribute("a2_prop19_nullable_byteArray")]
        public byte[]? A2_Prop19 { get; set; }
    }

    public class J3
    {
        [EpicAkSSkipPropertyAttribute()]
        public string J3_Prop1 { get; set; } = string.Empty;

        [EpicAkSPropertyNameAliasAttribute("j3_prop2_nullable_string")]
        public string? J3_Prop2 { get; set; }

        public string? J3_Prop3 { get; set; }

        [EpicAkSPropertyNameAliasAttribute("j3_prop4_nullable_j4")]
        public J4? J3_Prop4 { get; set; }
    }

    public class J4
    {
        [EpicAkSPropertyNameAliasAttribute("j4_prop1")]
        public string J4_Prop1 { get; set; } = String.Empty;
    }

    public class J5
    {

    }

    public class J6
    {
        [EpicAkSPropertyNameAliasAttribute("j6_prop1")]
        public string[] J6_Prop1 { get; set; } = new string[] { "Swiggy", "Zomato" };
    }

    public class J7
    {
        [EpicAkSPropertyNameAliasAttribute("j7_prop1")]
        public J6[] J7_Prop1 { get; set; } = new J6[] { new(), new J6 { J6_Prop1 = new string[] { "Dad", "Mom" } } };
    }
}
