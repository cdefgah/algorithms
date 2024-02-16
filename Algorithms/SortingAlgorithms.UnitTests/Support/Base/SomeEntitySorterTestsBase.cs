using Cdefgah.SortingAlgorithms.Interfaces;

using SortingAlgorithms.UnitTests.Support.Data;

namespace Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

public abstract class SomeEntitySorterTestsBase <TSorter> where TSorter : ISorter<SomeEntity>, new()
{
    private readonly TSorter sorter;

    public SomeEntitySorterTestsBase()
    {
        sorter = new TSorter();
    }

    [Theory]
    [ClassData(typeof(SomeEntitySorterTestData))]
    public void SortingTest(IList<SomeEntity?> initialArray, IList<SomeEntity?> expectedSortedArray)
    {
        sorter.Sort(initialArray);
        Assert.Equal(expectedSortedArray, initialArray);
    }
}
