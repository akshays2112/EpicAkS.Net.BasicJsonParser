using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.TestingIfAllTypesWork;

namespace MSTestsForEpicAkS.Net.BasicJsonParser
{
    [TestClass]
    public class TestJsonHelpers
    {
        [TestInitialize]
        public void InitializeUnitTests() => JsonHelpers.Initialize();

        #region Serialize Tests

        [TestMethod]
        public void Test1_Serialize_TC_Strings()
        {
            JsonHelpers.NoWhitespace = true;
            TC_BoolArrays tc_BoolArrays = new();
            Assert.IsTrue(JsonHelpers.Serialize(tc_BoolArrays)?.Equals("{\"tc_boolArrays_boolArray_prop1\":[],\"tc_boolArrays_nullableBoolArray_prop2\":[],\"tc_boolArrays_boolArrayNullable_prop3\":null,\"tc_boolArrays_nullableBoolArrayNullable_prop4\":null,\"tc_boolArrays_booleanArray_prop5\":[],\"tc_boolArrays_nullableBooleanArray_prop6\":[],\"tc_boolArrays_booleanArrayNullable_prop7\":null,\"tc_boolArrays_nullableBooleanArrayNullable_prop8\":null}"));
        }

        #endregion
    }
}
