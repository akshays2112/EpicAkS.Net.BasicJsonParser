using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.EpicAkSTestingIfAllTypesWork;
using EpicAkSAutoFillData;

namespace MSTestsForEpicAkS.Net.BasicJsonParser
{
    [TestClass]
    public class TestJsonHelpers
    {
        [TestInitialize]
        public void InitializeUnitTests() => EpicAkSJsonHelpers.Initialize();

        #region Serialize Tests

        [TestMethod]
        public void Serialize1_TC_Strings()
        {
            TC_Strings? tc_Strings = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_Strings>(new());
            EpicAkSJsonHelpers.NoWhitespace = true;
            TC_Strings? msJson_tc_Strings = System.Text.Json.JsonSerializer.Deserialize<TC_Strings>(
                EpicAkSJsonHelpers.Serialize(tc_Strings) ?? "{}");
            Assert.IsTrue(EpicAkSAutoFillDataForClassProperties.CompareInstancesOfAClass(tc_Strings, msJson_tc_Strings));
        }

        [TestMethod]
        public void Serialize2_TC_StringArrays()
        {
            TC_StringArrays? tc_StringArrays = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_StringArrays>(new());
            EpicAkSJsonHelpers.NoWhitespace = true;
            TC_StringArrays? msJson_tc_StringArrays = System.Text.Json.JsonSerializer.Deserialize<TC_StringArrays>(
                EpicAkSJsonHelpers.Serialize(tc_StringArrays) ?? "{}");
            Assert.IsTrue(EpicAkSAutoFillDataForClassProperties.CompareInstancesOfAClass(tc_StringArrays, msJson_tc_StringArrays));
        }

        #endregion

        #region Deserialize Tests

        [TestMethod]
        public void Deserialize1_TC_Strings()
        {
            TC_Strings? tc_Strings = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_Strings>(new());
            if (tc_Strings is null) return;
            TC_Strings? fromJson_tc_Strings = EpicAkSJsonHelpers.Deserialize(new TC_Strings(),
                System.Text.Json.JsonSerializer.Serialize<TC_Strings>(tc_Strings));
            Assert.IsTrue(EpicAkSAutoFillDataForClassProperties.CompareInstancesOfAClass(tc_Strings, fromJson_tc_Strings));
        }

        [TestMethod]
        public void Deserialize2_TC_StringArrays()
        {
            TC_StringArrays? tc_StringArrays = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_StringArrays>(new());
            if (tc_StringArrays is null) return;
            TC_StringArrays? fromJson_tc_StringArrays = EpicAkSJsonHelpers.Deserialize(new TC_StringArrays(),
                System.Text.Json.JsonSerializer.Serialize(tc_StringArrays));
            Assert.IsTrue(EpicAkSAutoFillDataForClassProperties.CompareInstancesOfAClass(tc_StringArrays, fromJson_tc_StringArrays));
        }

        #endregion
    }
}
