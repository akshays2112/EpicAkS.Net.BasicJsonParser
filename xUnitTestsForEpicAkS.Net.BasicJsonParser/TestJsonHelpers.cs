using Xunit;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.EpicAkSTestingIfAllTypesWork;
using EpicAkSAutoFillData;

namespace xUnitTestsForEpicAkS.Net.BasicJsonParser
{
    public class TestJsonHelpers
    {
        public TestJsonHelpers() => EpicAkSJsonHelpers.Initialize();

        [Fact]
        public void Test1()
        {
            TC_Strings? tc_Strings = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_Strings>(new());
            EpicAkSJsonHelpers.NoWhitespace = true;
            TC_Strings? msJson_tc_Strings = System.Text.Json.JsonSerializer.Deserialize<TC_Strings>(
                EpicAkSJsonHelpers.Serialize(tc_Strings) ?? "{}");
            Assert.True(EpicAkSAutoFillDataForClassProperties.CompareInstancesOfAClass(tc_Strings, msJson_tc_Strings));
        }
    }
}
