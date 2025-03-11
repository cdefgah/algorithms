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
        array = [.. Enumerable.Range(1, arrayElementsCount).Select(_ => random.Next())];
    }

    [Benchmark]
    public void BubbleSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new BubbleSorter<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void InsertionSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new InsertionSorter<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void SelectionSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new InsertionSorter<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void RecursiveQuickSortWithLomutoPartitioningSchemaBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new QuickSorterLomutoRecursive<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void NonRecursiveQuickSortWithLomutoPartitioningSchemaBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new QuickSorterLomutoNonRecursive<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void RecursiveQuickSortWithHoarePartitioningSchemaBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new QuickSorterHoareRecursive<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void NonRecursiveQuickSortWithHoarePartitioningSchemaBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new QuickSorterHoareNonRecursive<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void MergeSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new MergeSorter<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void ShellSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new ShellSorter<int>().Sort(dataToSort);
    }

    [Benchmark]
    public void TimSortBenchmark()
    {
        var dataToSort = (int[])array.Clone();
        new TimSorter<int>().Sort(dataToSort);
    }
}
