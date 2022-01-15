using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.TestingIfAllTypesWork;

namespace MSTestsForEpicAkS.Net.BasicJsonParser
{
    [TestClass]
    public class TestJsonHelpersOriginal
    {
        [TestInitialize]
        public void InitializeUnitTests() => JsonHelpers.Initialize();

        #region Serialize Tests

        [TestMethod]
        public void Test1_Serialize_X1()
        {
            JsonHelpers.NoWhitespace = false;
            X1 x1 = new();
            x1.X1_Prop1 = "X1_Prop1_Value";
            x1.X1_Prop2 = null;
            x1.X1_Prop3 = new();
            x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
            x1.X1_Prop3.A2_Prop2 = null;
            x1.X1_Prop4 = null;
            Assert.IsTrue(JsonHelpers.Serialize(x1)?.Equals("{ \"x1_prop1_string\" : \"X1_Prop1_Value\", \"x1_prop2_nullable_string\" : null, \"x1_prop3_class_A2\" : { \"a2_prop1_string\" : \"A2_Prop1_Value\", \"a2_prop2_nullable_string\" : null, \"a2_prop3_nullable_class_A2\" : null, \"a2_prop4_char\" : \"5\", \"a2_prop5_nullable_char\" : null, \"a2_prop6_int\" : 9, \"a2_prop7_nullable_int\" : null, \"a2_prop8_nullable_classArray_A2\" : null, \"a2_prop9_bool\" : true, \"a2_prop10_bool\" : false, \"a2_prop11_nullable_bool\" : null, \"a2_prop12_double\" : 6.26542, \"a2_prop13_nullable_double\" : null, \"a2_prop14_float\" : 1.2654199600219727, \"a2_prop15_nullable_float\" : null, \"a2_prop16_byte\" : \"/w==\", \"a2_prop17_nullable_byte\" : null, \"a2_prop18_byteArray\" : \"UwByAGkAbgBpAHYAYQBzAGEAbgA=\", \"a2_prop19_nullable_byteArray\" : null }, \"x1_prop4_nullable_class_A2\" : null, \"x1_prop5_char\" : \"2\", \"x1_prop6_nullable_char\" : null, \"x1_prop7_int\" : 3, \"x1_prop8_nullable_int\" : null, \"x1_prop9_classArray_A2\" : [  ], \"x1_prop10_nullable_classArray_A2\" : null, \"x1_prop11_bool\" : true, \"x1_prop12_bool\" : false, \"x1_prop13_nullable_bool\" : null, \"x1_prop14_double\" : 4.89567435, \"x1_prop15_nullable_double\" : null, \"x1_prop16_float\" : 8.395675659179688, \"x1_prop17_nullable_float\" : null, \"x1_prop18_byte\" : \"Wg==\", \"x1_prop19_nullable_byte\" : null, \"x1_prop20_byteArray\" : \"QQBrAHMAaABhAHkA\", \"x1_prop21_nullable_byteArray\" : null }"));
        }

        [TestMethod]
        public void Test2_Serialize_NoWhitespace_X1()
        {
            JsonHelpers.NoWhitespace = true;
            X1 x1 = new();
            x1.X1_Prop1 = "X1_Prop1_Value";
            x1.X1_Prop2 = null;
            x1.X1_Prop3 = new();
            x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
            x1.X1_Prop3.A2_Prop2 = null;
            x1.X1_Prop4 = null;
            Assert.IsTrue(JsonHelpers.Serialize(x1)?.Equals("{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.2654199600219727,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":\"/w==\",\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"UwByAGkAbgBpAHYAYQBzAGEAbgA=\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395675659179688,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":\"Wg==\",\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QQBrAHMAaABhAHkA\",\"x1_prop21_nullable_byteArray\":null}"));
        }

        [TestMethod]
        public void Test3_Newtonsoft_Json_Serialize_X1()
        {
            MSTestsFor.Net.BasicJsonParser.TestingAllTypesWorksNewtonsoftJson.X1 x1 = new();
            x1.X1_Prop1 = "X1_Prop1_Value";
            x1.X1_Prop2 = null;
            x1.X1_Prop3 = new();
            x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
            x1.X1_Prop3.A2_Prop2 = null;
            x1.X1_Prop4 = null;
            Assert.IsTrue(Newtonsoft.Json.JsonConvert.SerializeObject(x1)?.Equals("{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.26542,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":255,\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"U3Jpbml2YXNhbg==\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395676,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":90,\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QWtzaGF5\",\"x1_prop21_nullable_byteArray\":null}"));
        }

        [TestMethod]
        public void Test4_System_Text_Json_Serialize_X1()
        {
            MSTestsFor.Net.BasicJsonParser.TestingAllTypesWorksSystemTextJson.X1 x1 = new();
            x1.X1_Prop1 = "X1_Prop1_Value";
            x1.X1_Prop2 = null;
            x1.X1_Prop3 = new();
            x1.X1_Prop3.A2_Prop1 = "A2_Prop1_Value";
            x1.X1_Prop3.A2_Prop2 = null;
            x1.X1_Prop4 = null;
            Assert.IsTrue(System.Text.Json.JsonSerializer.Serialize(x1)?.Equals("{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.26542,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":255,\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"U3Jpbml2YXNhbg==\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395676,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":90,\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QWtzaGF5\",\"x1_prop21_nullable_byteArray\":null}"));
        }

        #endregion

        #region Serialize Tests

        [TestMethod]
        public void Test5_Deserialize_X1()
        {
            X1? x1 = new();
            x1 = JsonHelpers.Deserialize(x1, "{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.2654199600219727,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":\"/w==\",\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"UwByAGkAbgBpAHYAYQBzAGEAbgA=\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395675659179688,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":\"Wg==\",\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QQBrAHMAaABhAHkA\",\"x1_prop21_nullable_byteArray\":null}");
            Assert.IsNotNull(x1?.X1_Prop1 == "X1_Prop1_Value");
        }

        [TestMethod]
        public void Test6_Deserialize_J6()
        {
            J6? j6 = new();
            j6 = JsonHelpers.Deserialize(j6, "{\"j6_prop1\":[\"Swiggy\",\"Zomato\"]}");
            Assert.IsTrue(j6?.J6_Prop1[1] == "Zomato");
        }

        [TestMethod]
        public void Test7_Deserialize_J7()
        {
            J7? j7 = new();
            j7 = JsonHelpers.Deserialize(j7, "{\"j7_prop1\":[{\"j6_prop1\":[\"Swiggy\",\"Zomato\"},{\"j6_prop1\":[\"Dad\",\"Mom\"}]}");
            Assert.IsTrue(j7?.J7_Prop1[1].J6_Prop1[1] == "Mom");
        }

        [TestMethod]
        public void Test7_Deserialize_J8()
        {
            J8? j8 = new();
            j8 = JsonHelpers.Deserialize(j8, "{\"j8_prop1\":[{\"j6_prop1\":[\"Swiggy\",\"Zomato\"},{\"j6_prop1\":[\"Dad\",\"Mom\"}]}");
            Assert.IsTrue(j8?.J8_Prop1[1].J6_Prop1[1] == "Mom");
        }

        [TestMethod]
        public void Test8_Deserialize_Newtonsoft_Json_X1()
        {
            X1? x1 = Newtonsoft.Json.JsonConvert.DeserializeObject<X1>("{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.2654199600219727,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":\"FF\",\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"U3Jpbml2YXNhbg==\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395675659179688,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":\"5A\",\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QWtzaGF5\",\"x1_prop21_nullable_byteArray\":null}");
            Assert.IsNotNull(x1?.X1_Prop1 == "X1_Prop1_Value");
        }

        [TestMethod]
        public void Test9_Deserialize_System_Text_Json_X1()
        {
            X1? x1 = System.Text.Json.JsonSerializer.Deserialize<X1>("{\"x1_prop1_string\":\"X1_Prop1_Value\",\"x1_prop2_nullable_string\":null,\"x1_prop3_class_A2\":{\"a2_prop1_string\":\"A2_Prop1_Value\",\"a2_prop2_nullable_string\":null,\"a2_prop3_nullable_class_A2\":null,\"a2_prop4_char\":\"5\",\"a2_prop5_nullable_char\":null,\"a2_prop6_int\":9,\"a2_prop7_nullable_int\":null,\"a2_prop8_nullable_classArray_A2\":null,\"a2_prop9_bool\":true,\"a2_prop10_bool\":false,\"a2_prop11_nullable_bool\":null,\"a2_prop12_double\":6.26542,\"a2_prop13_nullable_double\":null,\"a2_prop14_float\":1.2654199600219727,\"a2_prop15_nullable_float\":null,\"a2_prop16_byte\":\"FF\",\"a2_prop17_nullable_byte\":null,\"a2_prop18_byteArray\":\"U3Jpbml2YXNhbg==\",\"a2_prop19_nullable_byteArray\":null},\"x1_prop4_nullable_class_A2\":null,\"x1_prop5_char\":\"2\",\"x1_prop6_nullable_char\":null,\"x1_prop7_int\":3,\"x1_prop8_nullable_int\":null,\"x1_prop9_classArray_A2\":[],\"x1_prop10_nullable_classArray_A2\":null,\"x1_prop11_bool\":true,\"x1_prop12_bool\":false,\"x1_prop13_nullable_bool\":null,\"x1_prop14_double\":4.89567435,\"x1_prop15_nullable_double\":null,\"x1_prop16_float\":8.395675659179688,\"x1_prop17_nullable_float\":null,\"x1_prop18_byte\":\"5A\",\"x1_prop19_nullable_byte\":null,\"x1_prop20_byteArray\":\"QWtzaGF5\",\"x1_prop21_nullable_byteArray\":null}");
            Assert.IsNotNull(x1?.X1_Prop1 == "X1_Prop1_Value");
        }

        #endregion
    }
}
