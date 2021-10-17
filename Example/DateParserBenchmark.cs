using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Example
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string DateTimeAsString = "2021-10-19T13:05:31Z";
        private readonly DateParser Parser= new();

        [Benchmark(Baseline =true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTimeAsString);
        }

        [Benchmark]
        public void GetYearFromDateTimeFromSplit()
        {
            Parser.GetYearFromDateTimeFromSplit(DateTimeAsString);
        }
        [Benchmark]
        public void GetYearFromDateTimeFromIndex()
        {
            Parser.GetYearFromDateTimeFromIndex(DateTimeAsString);
        }
        [Benchmark]
        public void GetYearFromDateTimeFromSpan()
        {
            Parser.GetYearFromDateTimeFromSpan(DateTimeAsString);
        }
        [Benchmark]
        public void GetYearFromDateTimeFromManualConversion()
        {
            Parser.GetYearFromDateTimeFromSpanManualConversion(DateTimeAsString);
        }

    }
}
