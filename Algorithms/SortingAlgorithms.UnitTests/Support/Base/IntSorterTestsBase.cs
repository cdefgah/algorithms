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
        IList<int> unsortedCollection,
        IList<int> expectedSortedCollection)
    {
        var unsortedCollectionCopy = unsortedCollection.ToArray();
        var expectedSortedCollectionCopy = expectedSortedCollection.ToArray();

        var sorter = CreateSorter(comparer);
        sorter.Sort(unsortedCollectionCopy);
        Assert.Equal(expectedSortedCollectionCopy, unsortedCollectionCopy);
    }

    [Fact]
    public void TestAttemptToSortNullArrayThrowsCorrectException()
    {
        var sorter = CreateSorter(Comparer<int>.Default);
        IList<int>? nullArray = null;

#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Throws<ArgumentNullException>(() => sorter.Sort(nullArray));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}