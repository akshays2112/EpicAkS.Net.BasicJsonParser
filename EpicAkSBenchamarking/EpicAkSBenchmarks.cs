using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using EpicAkS.Net.BasicJsonParser;
using EpicAkS.Net.BasicJsonParser.WebAPIClasses.ServiceProviders.EpicAkSTestingIfAllTypesWork;
using EpicAkSAutoFillData;
using Newtonsoft.Json;

namespace EpicAkSBenchamarking
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn()]
    public class EpicAkSBenchmarks
    {
        private readonly static TC_Strings? tc_Strings = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_Strings>(new());
        private readonly static TC_StringArrays? tc_StringArrays = EpicAkSAutoFillDataForClassProperties.AutoFillDataForObject<TC_StringArrays>(new());

        [Benchmark]
        public void EpicAkS_Serialize_TC_Strings()
        {
            _ = EpicAkSJsonHelpers.Serialize(tc_Strings);
        }

        [Benchmark]
        public void NewtonsoftJson_Serialize_TC_Strings()
        {
            _ = JsonConvert.SerializeObject(tc_Strings);
        }

        [Benchmark]
        public void SystemTextJson_Serialize_TC_Strings()
        {
            _ = System.Text.Json.JsonSerializer.Serialize(tc_Strings);
        }

        [Benchmark]
        public void Serialize2_TC_StringArrays()
        {
            _ = EpicAkSJsonHelpers.Serialize(tc_StringArrays);
        }

        [Benchmark]
        public void NewtonsoftJson_Serialize_TC_StringArrays()
        {
            _ = JsonConvert.SerializeObject(tc_StringArrays);
        }

        [Benchmark]
        public void SystemTextJson_Serialize_TC_StringArrays()
        {
            _ = System.Text.Json.JsonSerializer.Serialize(tc_StringArrays);
        }
    }
}
