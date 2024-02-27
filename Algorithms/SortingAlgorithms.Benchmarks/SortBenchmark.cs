using BenchmarkDotNet.Attributes;

namespace Cdefgah.SortingAlgorithms.Benchmarks;

[MemoryDiagnoser]
public class SortBenchmark
{
    private int[] array;

    [Params(1000, 5000, 10000, 25000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        array = Enumerable.Range(1, N).Select(_ => random.Next()).ToArray();
    }

    [Benchmark]
    public void BubbleSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new BubbleSorter<int>().Sort(sortedData);
    }

    [Benchmark]
    public void InsertionSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new InsertionSorter<int>().Sort(sortedData);
    }

    [Benchmark]
    public void SelectionSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new InsertionSorter<int>().Sort(sortedData);
    }

    [Benchmark]
    public void QuickSortWithLomutoPartitioningSchemaBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new QuickSorterLomuto<int>().Sort(sortedData);
    }
}
