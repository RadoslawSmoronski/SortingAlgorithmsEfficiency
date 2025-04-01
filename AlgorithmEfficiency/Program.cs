using BenchmarkDotNet.Running;
using SortingBenchmarks;

namespace SortingAlgorithmsEfficiency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortingBenchmark>();
        }
    }
}
