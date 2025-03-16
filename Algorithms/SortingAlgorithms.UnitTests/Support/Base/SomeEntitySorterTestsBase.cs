using Cdefgah.SortingAlgorithms.Interfaces;

using SortingAlgorithms.UnitTests.Support.Data;

namespace Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

public abstract class SomeEntitySorterTestsBase <TSorter> where TSorter : ISorter<SomeEntity>, new()
{
    protected readonly Func<IComparer<SomeEntity>, TSorter> CreateSorter;

    protected SomeEntitySorterTestsBase(Func<IComparer<SomeEntity>, TSorter> sorterFactory)
    {
        CreateSorter = sorterFactory;
    }

    [Theory]
    [ClassData(typeof(SomeEntitySorterTestData))]
    public void SortingTest(IComparer<SomeEntity> comparer, 
                            IList<SomeEntity?> initialArray, 
                            IList<SomeEntity?> expectedSortedArray)
    {
        var sorter = CreateSorter(comparer);
        sorter.Sort(initialArray);
        Assert.Equal(expectedSortedArray, initialArray);
    }
}
