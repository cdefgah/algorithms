using Cdefgah.SortingAlgorithms.Interfaces;

using SortingAlgorithms.UnitTests.Support.Data;

namespace Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

public abstract class IntSorterTestsBase<TSorter> where TSorter : ISorter<int>
{
    protected readonly Func<IComparer<int>, TSorter> CreateSorter;

    protected IntSorterTestsBase(Func<IComparer<int>, TSorter> sorterFactory)
    {
        CreateSorter = sorterFactory;
    }

    [Theory]
    [ClassData(typeof(IntSortingTestData))]
    public void SortingTest(
        IComparer<int> comparer,
        IList<int> initialArray,
        IList<int> expectedSortedArray)
    {
        var sorter = CreateSorter(comparer);
        sorter.Sort(initialArray);
        Assert.Equal(expectedSortedArray, initialArray);
    }
}