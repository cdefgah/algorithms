using Cdefgah.SortingAlgorithms.Interfaces;

using SortingAlgorithms.UnitTests.Support.Data;

namespace Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

public abstract class IntSorterTestsBase<TSorter> where TSorter : ISorter<int>, new()
{
    private readonly TSorter sorter;

    public IntSorterTestsBase()
    {
        sorter = new TSorter();
    }

    [Theory]
    [ClassData(typeof(IntSortingTestData))]
    public void SortingTest(IList<int> initialArray, IList<int> expectedSortedArray)
    {
        sorter.Sort(initialArray);
        Assert.Equal(expectedSortedArray, initialArray);
    }
}