using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.TestingIfAllTypesWork;

namespace MSTestsForEpicAkS.Net.BasicJsonParser
{
    [TestClass]
    public class TestJsonHelpers
    {
        [TestInitialize]
        public void InitializeUnitTests() => JsonHelpers.NamespaceScoped = "EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.";

        [TestMethod]
        public void TestSerialize_X1()
        {
            X1 x1 = new();
            x1.X1_Prop1 = "X1_Prop1_Value";
            x1.X1_Prop2 = null;
            x1.X1_Prop3 = new();
            x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
            x1.X1_Prop3.A2_Prop2 = null;
            x1.X1_Prop4 = null;
            Assert.IsTrue(JsonHelpers.Serialize(x1)?.Equals("{ \"x1_prop1_string\" : \"X1_Prop1_Value\", \"x1_prop2_nullable_string\" : null, \"x1_prop3_class_A2\" : { \"a2_prop1_string\" : \"A2_Prop1_Value\", \"a2_prop2_nullable_string\" : null, \"a2_prop3_nullable_class_A2\" : null, \"a2_prop4_char\" : \"5\", \"a2_prop5_nullable_char\" : null, \"a2_prop6_int\" : 9, \"a2_prop7_nullable_int\" : null, \"a2_prop8_nullable_classArray_A2\" : null, \"a2_prop9_bool\" : true, \"a2_prop10_bool\" : false, \"a2_prop11_nullable_bool\" : null, \"a2_prop12_double\" : 6.26542, \"a2_prop13_nullable_double\" : null, \"a2_prop14_float\" : 1.2654199600219727, \"a2_prop15_nullable_float\" : null, \"a2_prop16_byte\" : \"FF\", \"a2_prop17_nullable_byte\" : null, \"a2_prop18_byteArray\" : \"U3Jpbml2YXNhbg==\", \"a2_prop19_nullable_byteArray\" : null }, \"x1_prop4_nullable_class_A2\" : null, \"x1_prop5_char\" : \"2\", \"x1_prop6_nullable_char\" : null, \"x1_prop7_int\" : 3, \"x1_prop8_nullable_int\" : null, \"x1_prop9_classArray_A2\" : [  ], \"x1_prop10_nullable_classArray_A2\" : null, \"x1_prop11_bool\" : true, \"x1_prop12_bool\" : false, \"x1_prop13_nullable_bool\" : null, \"x1_prop14_double\" : 4.89567435, \"x1_prop15_nullable_double\" : null, \"x1_prop16_float\" : 8.395675659179688, \"x1_prop17_nullable_float\" : null, \"x1_prop18_byte\" : \"5A\", \"x1_prop19_nullable_byte\" : null, \"x1_prop20_byteArray\" : \"QWtzaGF5\", \"x1_prop21_nullable_byteArray\" : null }"));
        }

        [TestMethod]
        public void TestDeserialize_X1()
        {
            X1? x1 = new();
            x1 = JsonHelpers.Deserialize<X1>(x1, "{ \"x1_prop1_string\" : \"X1_Prop1_Value\", \"x1_prop2_nullable_string\" : null, \"x1_prop3_class_A2\" : { \"a2_prop1_string\" : \"A2_Prop1_Value\", \"a2_prop2_nullable_string\" : null, \"a2_prop3_nullable_class_A2\" : null, \"a2_prop4_char\" : \"5\", \"a2_prop5_nullable_char\" : null, \"a2_prop6_int\" : 9, \"a2_prop7_nullable_int\" : null, \"a2_prop8_nullable_classArray_A2\" : null, \"a2_prop9_bool\" : true, \"a2_prop10_bool\" : false, \"a2_prop11_nullable_bool\" : null, \"a2_prop12_double\" : 6.26542, \"a2_prop13_nullable_double\" : null, \"a2_prop14_float\" : 1.2654199600219727, \"a2_prop15_nullable_float\" : null, \"a2_prop16_byte\" : \"FF\", \"a2_prop17_nullable_byte\" : null, \"a2_prop18_byteArray\" : \"U3Jpbml2YXNhbg==\", \"a2_prop19_nullable_byteArray\" : null }, \"x1_prop4_nullable_class_A2\" : null, \"x1_prop5_char\" : \"2\", \"x1_prop6_nullable_char\" : null, \"x1_prop7_int\" : 3, \"x1_prop8_nullable_int\" : null, \"x1_prop9_classArray_A2\" : [  ], \"x1_prop10_nullable_classArray_A2\" : null, \"x1_prop11_bool\" : true, \"x1_prop12_bool\" : false, \"x1_prop13_nullable_bool\" : null, \"x1_prop14_double\" : 4.89567435, \"x1_prop15_nullable_double\" : null, \"x1_prop16_float\" : 8.395675659179688, \"x1_prop17_nullable_float\" : null, \"x1_prop18_byte\" : \"5A\", \"x1_prop19_nullable_byte\" : null, \"x1_prop20_byteArray\" : \"QWtzaGF5\", \"x1_prop21_nullable_byteArray\" : null }");
            Assert.IsNotNull(x1);
        }
    }
}
