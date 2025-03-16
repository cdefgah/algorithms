using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class BubbleSorterIntTests : IntSorterTestsBase<BubbleSorter<int>>
{
    public BubbleSorterIntTests() : base(comparer => new(comparer))
    {

    }
}
