using BenchmarkDotNet.Running;

namespace Cdefgah.SortingAlgorithms.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<SortBenchmark>();
    }
}
