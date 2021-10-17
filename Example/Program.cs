using BenchmarkDotNet.Running;

using System;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}
