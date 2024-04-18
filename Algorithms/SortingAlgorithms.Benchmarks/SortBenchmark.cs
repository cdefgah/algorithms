using BenchmarkDotNet.Attributes;

namespace Cdefgah.SortingAlgorithms.Benchmarks;

[MemoryDiagnoser]
public class SortBenchmark
{
    private int[] array;

    [Params(1000, 5000, 10000, 25000)]
    public int arrayElementsCount;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        array = Enumerable.Range(1, arrayElementsCount).Select(_ => random.Next()).ToArray();
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
    public void RecursiveQuickSortWithLomutoPartitioningSchemaBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new QuickSorterLomutoRecursive<int>().Sort(sortedData);
    }

    [Benchmark]
    public void NonRecursiveQuickSortWithLomutoPartitioningSchemaBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new QuickSorterLomutoNonRecursive<int>().Sort(sortedData);
    }

    [Benchmark]
    public void RecursiveQuickSortWithHoarePartitioningSchemaBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new QuickSorterHoareRecursive<int>().Sort(sortedData);
    }

    [Benchmark]
    public void NonRecursiveQuickSortWithHoarePartitioningSchemaBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new QuickSorterHoareNonRecursive<int>().Sort(sortedData);
    }

    [Benchmark]
    public void MergeSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new MergeSorter<int>().Sort(sortedData);
    }

    [Benchmark]
    public void ShellSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new ShellSorter<int>().Sort(sortedData);
    }

    [Benchmark]
    public void TimSortBenchmark()
    {
        var sortedData = (int[])array.Clone();
        new TimSorter<int>().Sort(sortedData);
    }
}
