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
                            IList<SomeEntity?> unsortedCollection, 
                            IList<SomeEntity?> expectedSortedCollection)
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
        var sorter = CreateSorter(Comparer<SomeEntity>.Default);
        IList<SomeEntity>? nullArray = null;

#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Throws<ArgumentNullException>(() => sorter.Sort(nullArray));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}
