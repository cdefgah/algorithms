using Cdefgah.SortingAlgorithms.UnitTests.Support;
using Cdefgah.SortingAlgorithms.UnitTests.Support.Base;

namespace Cdefgah.SortingAlgorithms.UnitTests;

public sealed class MergeSorterSomeEntityTests : SomeEntitySorterTestsBase<MergeSorter<SomeEntity>>
{
    public MergeSorterSomeEntityTests() : base(comparer => new(comparer))
    {

    }
}
